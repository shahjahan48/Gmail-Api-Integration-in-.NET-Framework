using Core;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Requests;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services
{
    public class EmailServices
    {
        static string[] Scopes = { GmailService.Scope.GmailReadonly };
        static string ApplicationName = "Gmail Api Test";
        GmailService service;

        public EmailServices()
        {
            UserCredential credential;
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "EmailClient",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Gmail API service.
            service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }
        public List<Emails> GetRangedEmails(DateTime afterDate, DateTime beforeDate, string category)
        {
            List<Emails> messages = new List<Emails>();
            messages = GetEmails(category, GmailFilter(afterDate, beforeDate));
            return messages;
        }
        private List<Emails> GetEmails(string category, string filter)
        {
            List<Emails> messages = new List<Emails>();
            int count = 0;

            // Define parameters of request.
            var request = service.Users.Messages.List("me");
            request.LabelIds = category.ToUpper();
            request.IncludeSpamTrash = false;
            request.Q = filter;

            // List labels.
            do
            {
                try
                {
                    var response = request.Execute();
                    var ids = new List<string>();
                    foreach (var item in response.Messages)
                    {
                        ids.Add(item.Id);
                    }
                    request.PageToken = response.NextPageToken;
                    messages.AddRange(BatchDownloadEmails(ids));
                    count++;
                    Console.WriteLine(count);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }
            } while (!String.IsNullOrEmpty(request.PageToken));

            return messages;
        }
        public IList<Emails> BatchDownloadEmails(IEnumerable<string> messageIds)
        {
            // Create a batch request.
            var request = new BatchRequest(service);
            var messages = new List<Emails>();

            foreach (var messageId in messageIds)
            {
                var messageBodyRequest = service.Users.Messages.Get("me", messageId);
                messageBodyRequest.Format = UsersResource.MessagesResource.GetRequest.FormatEnum.Full;
                request.Queue<Message>(messageBodyRequest,
                    (content, error, index, message) =>
                    {
                        String from = string.Empty;
                        String to = string.Empty;
                        String date = string.Empty;
                        String subject = string.Empty;
                        //String body = "";
                        //Loop through the headers and get the fields we need...
                        var msg = content;
                        foreach (var mParts in content.Payload.Headers)
                        {
                            if (mParts.Name == "Date")
                            {
                                date = mParts.Value;
                            }
                            else if (mParts.Name == "From")
                            {
                                from = mParts.Value;
                            }
                            else if (mParts.Name == "To")
                            {
                                to = mParts.Value;
                            }
                            else if (mParts.Name == "Subject")
                            {
                                subject = mParts.Value;
                            }

                            //if (date != "" && from != "")
                            //{
                            //    if (emailInfoResponse.Payload.Parts == null && emailInfoResponse.Payload.Body != null)
                            //    {
                            //        body = emailInfoResponse.Payload.Body.Data;
                            //    }
                            //    else
                            //    {
                            //        body = getNestedParts(emailInfoResponse.Payload.Parts);
                            //    }
                            //    // Need to replace some characters as the data for the email's body is base64
                            //    String codedBody = body.Replace("-", "+");
                            //    codedBody = codedBody.Replace("_", "/");
                            //    byte[] data = Convert.FromBase64String(codedBody);
                            //    body = Encoding.UTF8.GetString(data);

                            //    // Now you have the data you want...                         
                            //}
                        }
                        var email = new Emails();
                        email.from_address = from.Substring(from.LastIndexOf('<') + 1, from.Length - from.LastIndexOf('<') - 2);
                        email.to_address = to;
                        email.subject = subject;
                        email.body = content.Snippet;
                        email.received_date = DateParser(date);
                        messages.Add(email);
                    });
            }

            request.ExecuteAsync().Wait();
            return messages;
        }
        private Nullable<DateTime> DateParser(string input)
        {
            Nullable<DateTime> output;
            try
            {
                output = Convert.ToDateTime(input.Substring(0, input.LastIndexOf('+')).Trim());
            }
            catch (Exception)
            {
                output = null;
            }

            return output;
        }
        private string getNestedParts(IList<MessagePart> part)
        {
            string str = string.Empty;
            if (part == null)
            {
                return str;
            }
            else
            {
                foreach (var parts in part)
                {
                    if (parts.Parts == null)
                    {
                        if (parts.Body != null && parts.Body.Data != null)
                        {
                            str += parts.Body.Data;
                        }
                    }
                    else
                    {
                        return getNestedParts(parts.Parts);
                    }
                }

                return str;
            }
        }
        
        private string GmailFilter(DateTime afterDate, DateTime beforeDate)
        {
            var filter = "after:" + afterDate.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture) + " ";
            filter += "before:" + beforeDate.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

            return filter;
        }
    }
}
