using MarsFramework.Pages;
using NUnit.Framework;


namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test, Order(1)]
            [System.Obsolete]
            public void TestAddShareSkill()
            {
                ShareSkill shareSkill = new ShareSkill();
                shareSkill.EnterShareSkill();
            }
            [Test, Order(2)]
            [System.Obsolete]
            public void ViewManageShareSkill()
            {
                ManageListings manageListing = new ManageListings();
                manageListing.ViewListings();
                string firstskilltitle = manageListing.getfirsttitle();
                Assert.That(firstskilltitle == "Java", "title doest not match");

            }

            [Test, Order(3)]
            [System.Obsolete]
            public void EditManageShareskill()
            {
                ManageListings managelistings = new ManageListings();
                managelistings.editListings();
                string expectedtitle = managelistings.editListings();
                string firstskilltitle = managelistings.getfirsttitle();
                Assert.That(firstskilltitle == expectedtitle, "title doest not match");
            }

            [Test, Order(4)]
            [System.Obsolete]
            public void DeleteListings()
            {
                ManageListings managelistings = new ManageListings();
                string message = managelistings.deleteListings();
                string actualmessage = managelistings.getpopupmessage();
                Assert.AreEqual(message, actualmessage);

            }

        }
    }
}