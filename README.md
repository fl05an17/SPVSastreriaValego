# SPVSastreriaValego
Sistema de inventario y ventas desarrollado a la medida para empresa Sastreria Valego

Comentarios archivo App.config
Aqui agregamos la cadena String para realizar la conexion con la base de datos que corresponda a nuestro proyecto
Codigo EJEMPLO dentro del archivo
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.1" />
    </startup>
  //Agregamos esta linea
  name="(Aqui va el nombre de nuestra conexion, puede ser cualquier nombre)"
  connectionString="(Aqui va la cadena de conexion que podemos encontrar en las propiedades de nuestra base de datos"
  <connectionStrings>
    <add name="connstring" connectionString="Data Source=DESKTOP-787TG0Q\SQLEXPRESS;Initial Catalog=dbSastreriaValego;Integrated Security=True"/>  
  </connectionStrings>
  //Hata aqui
</configuration>
