using System.Management.Automation;

namespace SendGrid.PowerShell
{
    [Cmdlet(VerbsCommon.Add, "SendGridAccount")]
    public class AddSendGridAccount : Cmdlet
    {
        [Parameter(Position = 1, Mandatory = true)]
        [ValidateNotNull]
        public PSCredential Credential { get; set; }

        protected override void ProcessRecord()
        {
            var credential = Credential.GetNetworkCredential();

            WriteWarning($"Account \"{credential.UserName}\" has been added");
        }
    }
}
