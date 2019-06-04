DESARROLLO DE APLICACIÓN MOVIL 
PARA EL PLANETARIO DE CHIMALHUACAN


Introducción

El domo de Chimalhuacán que se encuentra ubicado en el municipio de Chimalhuacán Estado de México.
Tiene algunas similitudes con el del Politécnico Luis Enrique Erro, pero es un poco más grande (le faltan algunos detalles por terminar). Su domo (considerado la joya de la casa) de inmersión digital cuenta con tecnología 4k, 220 butacas reclinables y audio envolvente 3D. Con todos estos adelantos y recursos es uno de los más equipados del país.
Pero aún tiene algunos detalles, es por eso que se ve en la necesidad de elaborar aplicaciones que sirvan 
de intermediarios entre el usuario y planetario.

Justificación

Debido a la afluencia que ha generado el domo digital de Chimalhuacán se vio la necesidad de generar 
una aplicación móvil para fomentar la divulgación de la ciencia y tecnología al oriente de la ciudad de México.


Metodología

Se utilizará una metodología en cascada.
Modelo lineal secuencial


Modelo lineal:
Es usado en diferentes maneras de acuerdo al contexto. La manera más frecuente es en conexión con modelos de regresión y el término a menudo se toma como un sinónimo del modelo de regresión lineal 
•	En la figura anterior se puede ver un ejemplo del modelo lineal, que será la manera en que se trabajará en este proyecto.


Autores
Equipo de desarrollo

Nombre completo	Correo	Teléfono	Puesto
Tomas David Mendoza Aguilar	Davidmendoza1234560@gmail.com	55 39 74 06 16	Programador

Nombre completo	Correo	Teléfono	Puesto
Uriel Ángel Olguín	uriel_fantastic@hotmail.com
	55 76 83 94 41	Diseño  Interfaz

Nombre completo	Correo	Teléfono	Puesto
José Luis Saavedra Soria	Saavedra541@gmail.com	55 16 14 17 43	Implementación



Análisis

El sistema software permitirá la difusión de información. Este sistema permitirá a sus usuarios navegar en la aplicación que contará 
con diferentes interfaces para horarios en salas la información requerida, además de otras funciones como
las de consultar el horario de proyección del domo digital, etc. 
La funcionalidad de este sistema básicamente es la siguiente: un usuario 


versiones:
app Versión	1.0

versiones de android compatibles:
5.0 a la 8.1

licencia:
GNU GENERAL PUBLIC LICENSE
Version 3, 29 June 2007

Componentes y desarrollo SW
Programación
efecto de deslizacion de la app

    [ Actividad ( Etiqueta  =  " Chimalhuacan planetario " , Icono  =  " @ dibujable / logos " , Tema  =  " Estilo / MainTheme " 
    , MainLauncher  =  falso , ConfigurationChanges  =  ConfigChanges . ScreenSize  |  ConfigChanges . Orientación )]
     Clase  pública MainActivity : global :: Xamarin . Formas . Plataforma . Androide . FormsAppCompatActivity
    {
         anulación  protegida anulada  OnCreate ( Bundle  savedInstanceState )
        {
            TabLayoutResource  =  Recurso . Layout . Tabbar ;
            ToolbarResource  =  Recurso . Layout . Barra de herramientas ;

            de base . OnCreate ( savedInstanceState );
            global :: Xamarin . Formas . Formas . Init ( esto , savedInstanceState );
            LoadApplication ( nueva  aplicación ());
        }
    }
}

Pre-requisitos
se requiere un Phone con la version de android 5.0 minimo
En la realizacion de la programacion se requiere una PC con el programa android studio para la creacion
de places, metodos y funciones requeridos en el diseño de la app 

Construido con
android studio y visual studio 2017
en los lenguajes respectivos de C# Y JAVA

para el enpaquetado del proyecto se utilizo el programa Bizagi Model


Instalación 
paso 1:
se descarga la APK 
paso 2:
de da clic sobre el icono:
pase 3:
ir a ajustes y activar la opcion de permitir instalar aplicaciones de fuentes desconocidas
paso 4:
te mandara un mensaje de aceptar para instalar 
paso 5:
comenzara la instalacion de la APK 
paso 6:
damos clic a finalizar 
paso 7:
abrimos la APP en nuestro dispositivo

Ejecutando las pruebas
xamarin cuenta con un ejecutador de codigo para deteminar los errores que se presenten en el codigo 
y a su vez emula el comportamiento que tiene la app, si en algun momento se genera un error 
el emulador mostrara la linea de error asi mismo una especificacion del mismo
las pruebas realizadas en el emulador y a su vez se realizaron pruebas en dispostivos android de versiones
5.0, 7.0 y 8.1 
