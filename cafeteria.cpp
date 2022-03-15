#include<iostream>

using namespace std;
//simulador
int main(){
int orden;
    double precio[]={250.00,300.00,350.00,400.00,450.00};
string sandwiches[]={"Cubano","Hawaiano","Tropical","Olimpico","Completo"};
string Hecho_por="SCARLET FALETTE, MATRICULA: 100336643";
bool materiales =false;
string quedan_materiales;
cout << "Programa para Ordenar Sandwiches"<<endl<<endl;
do{

cout<<"1)Cubano, 2)Hawaiano, 3)Tropical, 4)Olimpico, 5)Completo"<< endl;
cout<<"Introduzca el numero del Sandwich que desea ordenar: "; cin>> orden;
orden -=1;
cout <<"Pedido listo: Sandwich "<<sandwiches[orden]<< ", el precio es $RD"<<precio[orden]<<endl<<endl;
cout << "Quedan mas materiales: ";cin.ignore(); getline(cin,quedan_materiales);

if(quedan_materiales=="Si, quedan"){
    materiales=true;
    cout << "Listo para el proximo pedido."<<endl;
}else{
materiales=false;
}

}while(materiales==true);





cout <<endl<< endl<<endl<<"Hecho por "<< Hecho_por <<endl;

return 0;
}
