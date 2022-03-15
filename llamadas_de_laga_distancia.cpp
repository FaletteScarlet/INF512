#include<iostream>
#include<ctime>

using namespace std;
struct Zona{
double USA=8.0, Centroamerica=5.5, America_del_sur=6.3, Europa=9.7, Asia=16.3, Africa=16.0;



};
int main(){
    string Hecho_por="SCARLET FALETTE, MATRICULA: 100336643";
int clave;
char Colgar[3];
double Precio=0, Costo=0;
Zona ZONA;
int Minuto=0;
unsigned t0, t1;
    cout <<"---------------Programa de llamadas de larga Distancia---------------------"<<endl<<endl;

    cout<<"Clave------Zona------Precio $RD/MIN"<<endl;
    cout <<1<<"-------USA----------------8.0"<<endl;
    cout <<15<<"------Centroamerica------5.5"<<endl;
    cout <<18<<"------America del Sur----6.3"<<endl;
    cout <<19<<"------Europa-------------9.7"<<endl;
    cout <<23<<"------Asia---------------16.3"<<endl;
    cout <<25<<"------Africa-------------16.0"<<endl<<endl;
    cout <<"Digite la clave de la Zona: "; cin>>clave;
t0=clock();
if (clave==1){
    Precio=ZONA.USA;
}else if(clave==15){
    Precio=ZONA.Centroamerica;
}else if(clave==18){
    Precio=ZONA.America_del_sur;
}else if (clave==19){
    Precio=ZONA.Europa;
}else if (clave==23){
    Precio=ZONA.Asia;
}else if (clave==25){
    Precio=ZONA.Africa;
}else{
cout << "Clave Incorrecta"<<endl;
}
cout <<"Colgar llamada: 'Escriba si cuando desee colgar la llamada' ";cin.ignore(); cin.getline(Colgar,3);

if(Colgar !=""){
t1 = clock();
double time = (double(t1-t0)/CLOCKS_PER_SEC);
Minuto= time/60;
if (Minuto<=0)Minuto=1;
Costo = Precio*Minuto;
cout << "El Precio por minuto es: " << Precio << endl;
cout << "Los Minutos de la llamada es: " << Minuto << endl;
cout << "El Costo de la llamada es: " << Costo << endl;
}



cout<<endl<<endl<<endl<< "Hecho por "<< Hecho_por;
return 0;
}
