using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UIAutomationTests
{
    public class Selenium
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            // Inicializa el navegador Edge
            _driver = new EdgeDriver();
        }

        [Test]
        public void Access_Country_List_Test()
        {
            // Paso 1: Ir a la página principal
            var URL = "http://localhost:8080/";
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(URL);

            // Paso 2: Verificar que exista el encabezado "Lista de paises"
            var encabezado = _driver.FindElement(By.XPath("//h1[contains(text(),'Lista de paises')]"));
            Assert.IsNotNull(encabezado);
            Assert.AreEqual("Lista de paises", encabezado.Text);
        }

        [Test]
        public void Navigate_To_Create_Form_Test()
        {
            // Paso 1: Ir a la página principal
            var URL = "http://localhost:8080/";
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(URL);

            // Paso 2: Verificar que el botón "Agregar país" está visible y hacer clic
            var botonAgregar = _driver.FindElement(By.XPath("//button[contains(text(),'Agregar país')]"));
            Assert.IsTrue(botonAgregar.Displayed);
            botonAgregar.Click();

            // Paso 3: Verificar que se haya cargado el formulario de creación
            var formHeader = _driver.FindElement(By.XPath("//h3[contains(text(),'Formulario de creación de países')]"));
            Assert.IsNotNull(formHeader);
        }

        [Test]
        public void Create_New_Country_Test()
        {
            // Paso 1: Ir a la página principal
            var URL = "http://localhost:8080/";
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(URL);

            // Paso 2: Clic en el botón para agregar país
            var botonAgregar = _driver.FindElement(By.XPath("//button[contains(text(),'Agregar país')]"));
            botonAgregar.Click();

            // Paso 3: Esperar a que se cargue el formulario
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("name")));

            // Paso 4: Llenar los campos del formulario
            _driver.FindElement(By.Id("name")).SendKeys("China");
            _driver.FindElement(By.Id("continente")).SendKeys("Asia");
            _driver.FindElement(By.Id("idioma")).SendKeys("Mandarín");

            // Paso 5: Enviar el formulario
            var botonGuardar = _driver.FindElement(By.XPath("//button[contains(text(),'Guardar')]"));
            Assert.IsTrue(botonGuardar.Enabled);
            botonGuardar.Click();

            // Paso 6: Esperar y validar el mensaje de confirmación (alert)
            var alerta = wait.Until(ExpectedConditions.AlertIsPresent());
            Assert.AreEqual("País creado exitosamente.", alerta.Text);
            alerta.Accept();
        }

        [Test]
        public void Verify_Created_Country_In_Table_Test()
        {
            // Paso 1: Ir a la página principal
            var URL = "http://localhost:8080/";
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(URL);

            // Paso 2: Verificar que el país "China" aparece en la tabla
            Assert.IsTrue(_driver.PageSource.Contains("China"));
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
