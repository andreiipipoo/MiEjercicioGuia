#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>



int main(int argc, char *argv[])
{
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// establecemos el puerto de escucha
	serv_adr.sin_port = htons(9080);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	int i;
	// bucle infinito
	for (;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		//sock_conn es el socket que usaremos para este cliente
		
		// Ahora recibimos la petici?n
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibido\n");
		
		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		peticion[ret]='\0';
		
		
		
		printf ("Peticion: %s\n",peticion);
		
		// vamos a ver que quieren
		char *p = strtok( peticion, "/");
		int codigo =  atoi (p);
		// Ya tenemos el c?digo de petici?n
		p = strtok( NULL, "/");
		float grados = atof(p);
		//Ya tenemos el numero
		printf ("Codigo: %d, Grados: %d\n", codigo, grados);
		
		if (codigo ==1) //Convertidor de Celsius a Fahrenhei
		{
			float fahrenheit;
			
			fahrenheit = (grados * 9/5) + 32;
			printf (respuesta,"%.2f Fahrenheit",fahrenheit);
		}
		else if (codigo ==2) // quieren saber si el nombre es bonito
		{
			float celsius;
			
			celsius = (grados - 32) * 5/9;
			printf(respuesta,"%.2f Celsius",celsius);
		}
		printf ("Respuesta: %s\n", respuesta);
		// Enviamos la respuesta
		write (sock_conn,respuesta, strlen(respuesta));
		
		// Se acabo el servicio para este cliente
		close(sock_conn); 
	}
}

