using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;

class Program
{
    static void Main()
    {
        try
        {
            // Configuración inicial del controlador de Chrome
            var options = new ChromeOptions();
            var driver = new ChromeDriver(options);

            // Carpeta para almacenar capturas de pantalla
            string captureFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CaptureFolder");
            if (!Directory.Exists(captureFolder))
            {
                Directory.CreateDirectory(captureFolder);
            }

            
            driver.Navigate().GoToUrl("https://localhost:7213/");
            CaptureSs(driver, Path.Combine(captureFolder, "1.png"));

            //gestioncaso agregar
            var botongestionc = driver.FindElement(By.Id("btngestioncasos1"));
            ExecuteJavaSclick(driver, botongestionc);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "2.png"));

            var botonagregar = driver.FindElement(By.Id("btnagregar1"));
            ExecuteJavaSclick(driver, botonagregar);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "3.png"));

            var boxfecha = driver.FindElement(By.Id("fecha_caso"));
            boxfecha.SendKeys("25-5-23");
            Thread.Sleep(TimeSpan.FromSeconds(3));
        

            var boxcliente = driver.FindElement(By.Id("cliente1"));
            boxcliente.SendKeys("Bob esponja");
            Thread.Sleep(TimeSpan.FromSeconds(3));
          

            var boxlat = driver.FindElement(By.Id("UbicacionLatitud"));
            boxlat.SendKeys("19.3214222");
            Thread.Sleep(TimeSpan.FromSeconds(3));
          

            var boxlong = driver.FindElement(By.Id("UbicacionLongitud"));
            boxlong.SendKeys("-69.5395818");
            Thread.Sleep(TimeSpan.FromSeconds(3));
         

            var boxtipodec = driver.FindElement(By.Id("Tipodecaso1"));
            boxtipodec.SendKeys("Robo");
            Thread.Sleep(TimeSpan.FromSeconds(3));
        

            var boxabogado = driver.FindElement(By.Id("Abogadoasignado1"));
            boxabogado.SendKeys("Parlon Pepe");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "9.png"));

            var boxestadodelcaso = driver.FindElement(By.Id("estadocaso1"));
            boxestadodelcaso.SendKeys("Abierto");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "10.png"));

            var boxdesc = driver.FindElement(By.Name("descripciondelcaso"));
            boxdesc.SendKeys("Bob esponja estaba paseando y le robaron");
            CaptureSs(driver, Path.Combine(captureFolder, "11.png"));

            var botonagregarcompleto = driver.FindElement(By.Id("btnagregarcasocompleto"));
            ExecuteJavaSclick(driver, botonagregarcompleto);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "12.png"));


            //modificar` caso
            var botongestioncaso2 = driver.FindElement(By.Id("btngestioncasos1"));
            ExecuteJavaSclick(driver, botongestioncaso2);
            Thread.Sleep(TimeSpan.FromSeconds(3));

            var botonmodificarcaso = driver.FindElement(By.Id("btnmodificarcaso1"));
            ExecuteJavaSclick(driver, botonmodificarcaso);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            CaptureSs(driver, Path.Combine(captureFolder, "14.png"));

            var boxidcasobuscar = driver.FindElement(By.Id("idCasoBuscar"));
            boxidcasobuscar.SendKeys("202300012");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            CaptureSs(driver, Path.Combine(captureFolder, "15.png"));

            var botonbuscarmodificarcaso = driver.FindElement(By.Name("buscarcaso1"));
            ExecuteJavaSclick(driver, botonbuscarmodificarcaso);
            Thread.Sleep(TimeSpan.FromSeconds(5));

            var boxmodiclienteedit = driver.FindElement(By.Id("clienteedit"));
            boxmodiclienteedit.SendKeys(" Pantalones Cuadrados");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            

            var botonguardarmodi = driver.FindElement(By.Id("btnguardaredicion"));
            ExecuteJavaSclick(driver, botonguardarmodi);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "18.png"));

            //agregar client

            var botongestioncliente = driver.FindElement(By.Id("btngestionclientes1"));
            ExecuteJavaSclick(driver, botongestioncliente);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            

            var botonaclientes = driver.FindElement(By.Id("btnaclientes"));
            ExecuteJavaSclick(driver, botonaclientes);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "20.png"));

            var boxclientecedula = driver.FindElement(By.Id("cedula"));
            boxclientecedula.SendKeys("001-4568746-7");
            Thread.Sleep(TimeSpan.FromSeconds(3));
         

            var boxclientenombre = driver.FindElement(By.Id("nombre"));
            boxclientenombre.SendKeys("Arenita");
            Thread.Sleep(TimeSpan.FromSeconds(3));
          

            var boxclienteapellido = driver.FindElement(By.Id("apellido"));
            boxclienteapellido.SendKeys("Mejillas");
            Thread.Sleep(TimeSpan.FromSeconds(3));
           

            var boxclientecorreo = driver.FindElement(By.Id("correo"));
            boxclientecorreo.SendKeys("Amejillas@gmail.com");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            

            var boxclientetelefono = driver.FindElement(By.Id("telefono"));
            boxclientetelefono.SendKeys("809-469-4691");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "25.png"));

            var boxclientecelular = driver.FindElement(By.Id("celular"));
            boxclientecelular.SendKeys("829-846-8591");
            Thread.Sleep(TimeSpan.FromSeconds(3));
           

            var boxclientedireccion = driver.FindElement(By.Id("direccion"));
            boxclientedireccion.SendKeys("Fondo de bikini");
            Thread.Sleep(TimeSpan.FromSeconds(3));
           

            var boxclienteestadocivil = driver.FindElement(By.Id("estadocivil"));
            boxclienteestadocivil.SendKeys("soltera");
            Thread.Sleep(TimeSpan.FromSeconds(5));
           

            var botonagregarcliente1 = driver.FindElement(By.Id("botonagregarcliente"));
            ExecuteJavaSclick(driver, botonagregarcliente1);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "29.png"));

            //editar clientes

            var botonbneclientes = driver.FindElement(By.Id("bneclientes"));
            ExecuteJavaSclick(driver, botonbneclientes);
            Thread.Sleep(TimeSpan.FromSeconds(3));
      

            var boxcedulaBuscar = driver.FindElement(By.Id("cedulaBuscar"));
            boxcedulaBuscar.SendKeys("001-4568746-7");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "32.png"));

            var botonbuscarcedulacliente = driver.FindElement(By.Id("buscarcedulacliente"));
            ExecuteJavaSclick(driver, botonbuscarcedulacliente);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "33.png"));

            var boxcorreoeditc = driver.FindElement(By.Id("direccion2"));
            boxcorreoeditc.SendKeys("calle almeja esquina #3");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "34.png"));



            //reporte ver tabla y html

            var botonreportesver1 = driver.FindElement(By.Id("reportesver1"));
            ExecuteJavaSclick(driver, botonreportesver1);
            Thread.Sleep(TimeSpan.FromSeconds(3));
          

            var botonreportestabla1 = driver.FindElement(By.Id("reportestabla1"));
            ExecuteJavaSclick(driver, botonreportestabla1);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "37.png"));

            var botontablacasover = driver.FindElement(By.Id("botontablacaso"));
            ExecuteJavaSclick(driver, botontablacasover);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "38.png"));

            var botontablaverhtml = driver.FindElement(By.Id("abrirhtml"));
            ExecuteJavaSclick(driver, botontablaverhtml);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "39.png"));

            //reporte ver`````` mapa

    

            var botonreportesvermapa = driver.FindElement(By.Id("vermapa1"));
            ExecuteJavaSclick(driver, botonreportesvermapa);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "41.png"));

            var botonmapaoficial = driver.FindElement(By.Id("vermapa2"));
            ExecuteJavaSclick(driver, botonmapaoficial);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "42.png"));


            //configuracion agregar tipo de caso
            var botonconfiguracion = driver.FindElement(By.Id("btnconfiguracion1"));
            ExecuteJavaSclick(driver, botonconfiguracion);
            Thread.Sleep(TimeSpan.FromSeconds(3));
           

            var botontipodecaso = driver.FindElement(By.Id("agregatipodecaso1"));
            ExecuteJavaSclick(driver, botontipodecaso);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "44.png"));

            var boxagregartipodecaso = driver.FindElement(By.Id("nombreCaso3"));
            boxagregartipodecaso.SendKeys("Lesiones Personales");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "45.png"));


            // agregar estado

            var botonagregarestado2 = driver.FindElement(By.Id("agregaestadocliente"));
            ExecuteJavaSclick(driver, botonagregarestado2);
            Thread.Sleep(TimeSpan.FromSeconds(3));
           

            var boxestadocaso4 = driver.FindElement(By.Id("nombreEstado5"));
            boxestadocaso4.SendKeys("cerrado");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "51.png"));

            // agregar abogado

            var botonconfiagregarabogado = driver.FindElement(By.Id("agregaunabogado")); 
            ExecuteJavaSclick(driver, botonconfiagregarabogado);
            Thread.Sleep(TimeSpan.FromSeconds(3));
          

            var boxceduladeabogado = driver.FindElement(By.Id("cedula5"));
            boxceduladeabogado.SendKeys("005-7857469-5");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            

            var boxnombredeabogado = driver.FindElement(By.Id("nombreabogado6"));
            boxnombredeabogado.SendKeys("Fulanito Perez");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "55.png"));

            var botonagregarnombreabogado = driver.FindElement(By.Id("botoncompletoagregarabogado"));
            ExecuteJavaSclick(driver, botonagregarnombreabogado);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            

            //salir del programa


            var botondesalir = driver.FindElement(By.Id("salirdelprograma"));
            ExecuteJavaSclick(driver, botondesalir);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "57.png"));

            var botondesalircompleto = driver.FindElement(By.Id("salirdelboton"));
            ExecuteJavaSclick(driver, botondesalircompleto);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CaptureSs(driver, Path.Combine(captureFolder, "58.png"));


            // Crear un informe HTML con las capturas de pantalla
            string archivoreporte = Path.Combine(captureFolder, "Reporte_de_ss.html");
            GeneraHtmlReporte(captureFolder, archivoreporte);

            Console.WriteLine($"Informe HTML creado en: {archivoreporte}");

            Thread.Sleep(TimeSpan.FromSeconds(5));

            // Abrir el informe HTML en el navegador predeterminado
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = archivoreporte,
                UseShellExecute = true
            });
        }
        catch (Exception pro)
        {
            Console.WriteLine($"Error: {pro.Message}");
        }
    }

    // Método para ejecutar clics mediante JavaScript
    static void ExecuteJavaSclick(IWebDriver driver, IWebElement element)
    {
        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("arguments[0].click();", element);
    }

    // Método para capturar capturas de pantalla
    static void CaptureSs(IWebDriver driver, string filePath)
    {
        try
        {
            ITakesScreenshot screenshotsave = (ITakesScreenshot)driver;
            Screenshot screenshot = screenshotsave.GetScreenshot();
            screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);
        }
        catch (Exception prom)
        {
            Console.WriteLine($"Error al capturar ss en la pantalla: {prom.Message}");
        }
    }

    // Método para generar un informe HTML con las```` capturas de pantalla
    static void GeneraHtmlReporte(string captureFolder, string reportFilePath)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(reportFilePath))
            {
                sw.WriteLine("<!DOCTYPE html>");
                sw.WriteLine("<html lang=\"es\">");
                sw.WriteLine("<head>");
                sw.WriteLine("    <meta charset=\"UTF-8\">");
                sw.WriteLine("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
                sw.WriteLine("    <title>Informe de Capturas</title>");
                sw.WriteLine("    <style>");
                sw.WriteLine("        body { font-family: 'Arial', sans-serif; background-color: #f4f4f4; margin: 20px; }");
                sw.WriteLine("        h1 { color: #333; }");
                sw.WriteLine("        img { max-width: 100%; height: auto; border: 1px solid #ddd; margin-bottom: 10px; }");
                sw.WriteLine("    </style>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("    <h1>Informe de Capturas:</h1>");

                string[] imageFiles = Directory.GetFiles(captureFolder, "*.png");

                foreach (string imageFile in imageFiles)
                {
                    sw.WriteLine($"    <img src=\"{Path.GetFileName(imageFile)}\" alt=\"Captura de pantalla\">");
                }

                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }

            Console.WriteLine($"Informe HTML creado en: {reportFilePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al generar el informe HTML: {ex.Message}");
        }
    }
}

