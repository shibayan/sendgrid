SendGridSharp
=============

SendGridSharp - Yet Another SendGrid API C# Library

## Create Account ##

```c#
var account = SendGridAccount.Create("API_USER", "API_KEY");
```

or

```c#
var account = SendGridAccount.Parse("ApiUser=API_USER;ApiKey=API_KEY");
```

## API Requests ##

```c#
// Get Blocklist
var blockList = await account.Blocks.GetAsync(new GetBlocksParameter { Limit = 10 });

// Delete all from Bounces
await account.Bounces.DeleteAsync(new DeleteBouncesParameter { DeleteAll = true });

// Send Mail
var sendMail = new SendMailParameter
{
    From = "from@example.com",
    Text = "text content",
    Html = "<p>html content</p>
};

sendMail.To.Add("to@example.com");

await account.Mail.SendAsync(sendMail);
```

## Support APIs ##

- SMTP API (X-SMTP API)
- Web API
- Web API v3 (partial)
- Marketing Emails API (future)
- Webhooks (Inbound Parse / Event v3)