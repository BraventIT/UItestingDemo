using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using NUnit.Framework;

namespace UItesting
{
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void InvalidLogin()
        {
            app.WaitForElement(x => x.Id("txfUser"));
            app.Tap(x => x.Id("txfUser"));
            app.Screenshot("Tap en el campo Usuario");
            app.EnterText(x => x.Id("txfUser"),"aa");
            app.DismissKeyboard();

            app.Tap(x => x.Id("txfPass"));
            app.Screenshot("Tap en el campo Contraseña");
            app.EnterText(x => x.Id("txfPass"), "aa");
            app.DismissKeyboard();

            app.Tap(x => x.Text("Entrar"));

            app.Screenshot("Alert de error");

            app.Tap(x => x.Marked("OK"));
        }

        [Test]
        public void ValidLogin()
        {
            app.WaitForElement(x => x.Id("txfUser"));
            app.Tap(x => x.Id("txfUser"));
            app.Screenshot("Tap en el campo Usuario");
            app.EnterText(x => x.Id("txfUser"), "123");
            app.DismissKeyboard();

            app.Tap(x => x.Id("txfPass"));
            app.Screenshot("Tap en el campo Contraseña");
            app.EnterText(x => x.Id("txfPass"), "123");
            app.DismissKeyboard();

            app.Tap(x => x.Text("Entrar"));

            app.WaitForElement(x=>x.Marked("UITesting Xamarin"));
        }

        [Test]
        public void showTable()
        {
            app.WaitForElement(x => x.Id("txfUser"));
            app.Tap(x => x.Id("txfUser"));
            app.Screenshot("Tap en el campo Usuario");
            app.EnterText(x => x.Id("txfUser"), "123");
            app.DismissKeyboard();

            app.Tap(x => x.Id("txfPass"));
            app.Screenshot("Tap en el campo Contraseña");
            app.EnterText(x => x.Id("txfPass"), "123");
            app.DismissKeyboard();

            app.Tap(x => x.Text("Entrar"));

            app.WaitForElement(x => x.Marked("UITesting Xamarin"));

            app.Tap(x => x.Text("Ir a Tabla"));
        }
    }
}
