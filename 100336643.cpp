#include <iostream>
#include <fstream>
#include <string.h>
#include <esconu.h>


using namespace std;
int opcion, posicion=0,codigo[100], nolinea=0,y, codigol=0,confirmar;
string articulo[100], marca[100], linea[100];
double precio[100];
void abrirArchivo();
void guardarArchivo();
void Menu();
void acciones();
ifstream leerarchivo;
ofstream archivo;

int main(){
    abrirArchivo();
do{

    Menu();
    acciones();
}while (opcion != 4);
guardarArchivo();
return 0;


}
void abrirArchivo(){

leerarchivo.open("archivo.txt");
while (!leerarchivo.eof()){
getline(leerarchivo,linea[nolinea]);
    nolinea++;
}
nolinea=nolinea-1;
codigol = (nolinea-2);
leerarchivo.close();
};
void guardarArchivo(){

archivo.open("archivo.txt");
for (int n=0;n<nolinea;n++){
archivo << linea[n] << endl;
}

for (int a=0; a<posicion;a++){
    archivo << " "<<codigo[a] <<"      ";

    archivo << articulo[a] << "               ";

    archivo<< marca[a]<<"               ";

    archivo << precio[a] << endl;
}
archivo.close();
};

void Menu(){
    BorraPantalla();
    CoordenadaXY(29,2);
cout <<"Ferreteria Don Churumusco"<<endl;
CoordenadaXY(2,3);
cout << "Lista de Opciones: "<<endl;
cout << "1.Listar articulos"<<endl;
cout << "2.Agregar articulos"<<endl;
cout << "3.Eliminar articulo"<<endl;
cout << "4.Salir"<<endl;
cout << "Elija una Opcion: ";
cin>>opcion;

};

void acciones(){
if (opcion == 1){
        BorraPantalla();
        for (int n=0;n<nolinea;n++){
   cout<<linea[n]<<endl;
        }
   y = (nolinea+1);
for (int a=0; a<posicion;a++){
        CoordenadaXY(1,y);
    cout << codigo[a];
    CoordenadaXY(8,y);
    cout << articulo[a];
    CoordenadaXY(25,y);
    cout << marca[a];
    CoordenadaXY(42,y);
    cout << precio[a]<<endl;
    y++;
}

cout <<endl<<endl;
TeclaPresionada("Presione enter para continuar");
}
else if (opcion == 2){
    BorraPantalla();
    CoordenadaXY(29,2);
cout <<"Ferreteria Don Churumusco"<<endl;
codigo[posicion]=codigol;
CoordenadaXY(1,4);
cout << "Agregar los datos del articulo: ";
CoordenadaXY(2,6);
cout <<"Codigo de articulo: "<<codigo[posicion];
CoordenadaXY(2,7);
cout <<"Articulo: ";
CoordenadaXY(40,6);
cout <<"Marca: ";
CoordenadaXY(40,7);
cout <<"Precio: ";
CoordenadaXY(12,7);
cin.ignore();
getline(cin,articulo[posicion]);
CoordenadaXY(48,6);
getline(cin, marca[posicion]);
CoordenadaXY(48,7);
cin>> precio[posicion];
posicion++;
codigol++;
cout <<endl<<endl;
TeclaPresionada("Presione enter para continuar");

}
else if (opcion == 3){
    BorraPantalla();
    int eliminar;
    CoordenadaXY(29,2);
cout <<"Ferreteria Don Churumusco"<<endl;
CoordenadaXY(2,4);
cout <<"Digite el codigo del articulo que desea eliminar: ";cin>>eliminar;
if ((eliminar >= 1 && eliminar <= codigol)){
        int eliminarl= (eliminar + 2);
if (eliminarl >=nolinea){
CoordenadaXY(2,6);
cout <<"El articulo que desea eliminar es: "<<endl;
for(int d=0; d < posicion;d++){
        if (codigo[d]==eliminar){
CoordenadaXY(2,8);
cout << "Cod.";
CoordenadaXY(2,9);
cout << codigo[d];
CoordenadaXY(10,8);
cout << "Articulo ";
CoordenadaXY(10,9);
cout << articulo[d];
CoordenadaXY(40,8);
cout << "Marca";
CoordenadaXY(40,9);
cout << marca[d];
CoordenadaXY(65,8);
cout << "Precio"<<endl;
CoordenadaXY(65,9);
cout << precio[d];

CoordenadaXY(5,12);
cout<<"Desea eliminar el articulo: 1-Si/2-No "; cin >> confirmar;
if(confirmar==1){
 for (int b = d; b < posicion; b++)
                    {

                        codigo[b] = codigo[b+1]-1;
                        articulo[b] = articulo[b + 1];
                        marca[b] = marca[b + 1];
                        precio[b] = precio[b + 1];
                    }
                    posicion--;
                    cout << "Articulo eliminado exitosamente.";
        }else cout<<"Accion cancelada";

}
}
}else {
    CoordenadaXY(2,6);
cout <<"El articulo que desea eliminar es: "<<endl;
CoordenadaXY(2,8);
cout << "Cod.";
CoordenadaXY(8,8);
cout << "Articulo";
CoordenadaXY(25,8);
cout << "Marca";
CoordenadaXY(42,8);
cout << "Precio\n";
    cout << linea[eliminarl]<<endl;
CoordenadaXY(5,12);
cout<<"Desea eliminar el articulo: 1-Si/2-No "; cin >> confirmar;
if(confirmar==1){

linea[eliminarl]="";

                    cout << "Articulo eliminado exitosamente.";
}else cout << "Accion Cancelada.";
}


}
cout <<endl<<endl;
TeclaPresionada("Presione enter para continuar");
}


            };
