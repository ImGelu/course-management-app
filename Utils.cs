using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect
{
    static class Utils
    {
        public static CoursesWebServiceReference.CoursesWebService webService = new CoursesWebServiceReference.CoursesWebService();

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool EmailAlreadyTaken(string email)
        {
            CoursesWebServiceReference.User existingUser = webService.GetUserByEmail(email);

            return existingUser != null;
        }

        public static CoursesWebServiceReference.User GetLoggedInUser()
        {
            int loggedInUserId = Properties.Settings.Default.loggedInUserId;
            CoursesWebServiceReference.User existingUser = webService.GetUser(loggedInUserId);

            return existingUser;
        }

        private static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }

        public static void SetButtonImage(Button button, Bitmap image)
        {
            button.TextImageRelation = TextImageRelation.Overlay;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.UseCompatibleTextRendering = true;
            button.Image = ScaleImage(image, 32, 32);
        }

        public static void SetButtonImage(Button button, Bitmap image, int height, int length)
        {
            button.TextImageRelation = TextImageRelation.Overlay;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.UseCompatibleTextRendering = true;
            button.Image = ScaleImage(image, height, length);
        }

    }
}
