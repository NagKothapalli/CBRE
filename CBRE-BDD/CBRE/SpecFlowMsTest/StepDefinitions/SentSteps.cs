using SpecFlowMsTest.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowMsTest.StepDefinitions
{
    [Binding]
    public  class SentSteps
    {
        Sent mySent = new Sent();
        [When(@"I Navigate To Sent Items")]
        public void WhenINavigateToSentItems()
        {
            mySent.NavigateToSentItems();
        }

        [Then(@"I Should See All Sent Mails")]
        public void ThenIShouldSeeAllSentMails()
        {
            mySent.SeeSentMailsWithoutAttachment();
        }

        [Then(@"I Should See All Sent Mails With Attachment")]
        public void ThenIShouldSeeAllSentMailsWithAttachment()
        {
            mySent.SeeSentMailsWithAttachment();
        }

    }
}
