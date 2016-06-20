SendGrid C# Client
=============

## Create Account

```c#
var account = Account.Create("API_KEY");
```


## API Requests

```csharp
// Get Blocklist
var blockList = await account.Blocks.GetAsync(new GetBlocksParameter { Limit = 10 });

// Delete all from Bounces
await account.Bounces.DeleteAsync(new DeleteBouncesParameter { DeleteAll = true });

// Send Mail
var sendMail = new SendMailParameter
{
    From = "from@example.com",
    Text = "text content",
    Html = "<p>html content</p>"
};

sendMail.To.Add("to@example.com");

await account.Mail.SendAsync(sendMail);
```

## Support APIs

- SMTP API (X-SMTP API)
- Web API v3
- WebHooks (Inbound Parse / Event v3)

## License

[Apache License 2.0](https://github.com/shibayan/sendgrid/blob/master/LICENSE)