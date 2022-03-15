#include<iostream>
#include<math.h>


using namespace std;

int main(){
double Capital=3720000.00, intereses_anual= 13.5, cuota=0, intereses_mensuales=0, potencia=1,operacion=0;
int plazos=20, plazos_mensuales=0, a;
string Hecho_por="SCARLET FALETTE, MATRICULA: 100336643";

plazos_mensuales=plazos*12;
intereses_mensuales= intereses_anual/12;

/*for(a=0; a<plazos_mensuales; a++){
    potencia = potencia*(1+intereses_mensuales/100);
}
operacion = 1/potencia;*/

cuota = (Capital * intereses_mensuales) / (100 * (1- pow((1+(intereses_mensuales/100)),-plazos_mensuales)));

cout << "Programa para calcular la cuota mensual de prestamo."<<endl<<endl;

cout << "El valor del prestamo es 3,720,000.00, a un plazo de 20 anos con un interes de 13.5 anual." <<endl;
cout <<"La Cuota a pagar mensual sera "<< cuota<<endl;
cout <<"Hecho por "<< Hecho_por <<endl;






return 0;
}
