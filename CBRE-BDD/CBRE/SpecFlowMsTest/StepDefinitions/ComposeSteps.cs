using SpecFlowMsTest.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowMsTest.StepDefinitions
{
    [Binding]
    public  class ComposeSteps
    {
        Compose myCompose = new Compose();
        [Given(@"I Launch And Login To Gmail Application")]
        public void GivenILaunchAndLoginToGmailApplication()
        {
            myCompose.LaunchApplication();
            myCompose.LoginApplication();
        }

        [When(@"I Compose And Send An Email")]
        public void WhenIComposeAndSendAnEmail()
        {
            myCompose.ComposeMail();
            myCompose.SendMail();
        }

        [Then(@"The Email Should be Sent Successfully")]
        public void ThenTheEmailShouldBeSentSuccessfully()
        {
            myCompose.ValidateEmail();
        }

        [When(@"I Compose And Send An Email Without Attachment")]
        public void WhenIComposeAndSendAnEmailWithoutAttachment()
        {
            myCompose.ComposeMailWithOutAttachment();
        }

        [When(@"I Search With Subject '(.*)'")]
        public void WhenISearchWithSubject(string subject)
        {
            Console.WriteLine(" Subject is :" + subject);
        }

        [Then(@"I Should See All Monster Emails")]
        public void ThenIShouldSeeAllMonsterEmails()
        {
            Console.WriteLine("ThenIShouldSeeAllMonsterEmails");
        }
        [When(@"I Search With Subject ""(.*)"" and ""(.*)""")]
        public void WhenISearchWithSubjectAnd(string p0, string p1)
        {
            Console.WriteLine("Subject :" + p0  + " , From :" + p1 );
        }


    }
}
