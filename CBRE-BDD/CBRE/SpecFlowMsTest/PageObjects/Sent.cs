using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowMsTest.PageObjects
{
    public class Sent
    {
        public void NavigateToSentItems()
        {
            Console.WriteLine("Navigate To Sent Items");
        }

        public void SeeSentMailsWithoutAttachment()
        {
            Console.WriteLine("See SentMails WithoutAttachment");
        }
        public void SeeSentMailsWithAttachment()
        {
            Console.WriteLine("See SentMails With Attachment");
        }
    }
}
