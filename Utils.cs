using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Proiect.CoursesWebServiceReference;

namespace Proiect
{
    static class Utils
    {
        public static CoursesWebService webService = new CoursesWebService();

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

        public static bool IsValidURL(string url)
        {
            Regex rx = new Regex(@"(\b(http|ftp|https):(\/\/|\\\\)[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&:/~\+#]*[\w\-\@?^=%&/~\+#])?|\bwww\.[^\s])", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return rx.IsMatch(url);
        }

        public static bool EmailAlreadyTaken(string email)
        {
            User existingUser = webService.GetUserByEmail(email);

            return existingUser != null;
        }

        public static User GetLoggedInUser()
        {
            int loggedInUserId = Properties.Settings.Default.loggedInUserId;
            User existingUser = webService.GetUser(loggedInUserId);

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
