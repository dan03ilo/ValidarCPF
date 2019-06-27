using System;

namespace ValidarCPF
{
    class Program
    {
        static void Main(string[] args)
        {
           string cpfus, cpfcalc;
           int peso10=10, peso11=11, resto=0, resultado=0;

           Console.WriteLine("Digite seu CPF");
           cpfus = Console.ReadLine();

            /*
            Para pegar os nove primeiros digitos do cpf utilizamos o comando Substring, esse comando nos ajuda a "quebrar" uma string e
        pegar caracter a caracter de uma string.
            A primeira parte do comando substring é a posição onde devemos iniciar a captura dos caracteres.
            A segunda parte trata da quantidade de caracteres que iremos obter a partir da posição que foi inserida. No exemplo abaixo
        temos: Pegamos os números do cpf a partir da posição 0, ou seja, o primeiro digito e pedimos 9 digitos a partir desta posição.
             */
           cpfcalc = cpfus.Substring(0,9);

        //    Console.WriteLine(cpfcalc);
           /*
           Abaixo estamos imprimindo em tela a primeira posição do número do CPF, neste caso estamos usando a posição 0(zero)
            */

        //    Console.WriteLine(cpfcalc[0]);
            /*
            Estamos usando um laço for para obter um número por vez do cpf e multiplicar pelos pesos de 10 a 2.
            Como são 9 números realizamos a contagem no for a partir do 0(zero) e indo até 8, que totaliza 9 números.
             */
            for(int i=0; i <= 8; i++){
               // Console.WriteLine(cpfcalc[i]);
               /*
               Para realizar a multiplicação dos números do cpf com os pesos de 10 a 2 é necessário pegar um número por vez e converter
               para número e logo em seguida multiplicar pelo peso.
               O problema é que a conversão para inteiro só é possível com valores string. No entanto quando foi retirado o caracter de 
               string, não é possível converter para inteiro, pois in.Parse só converte string. Sendo assim, foi necessário converter o caracter
               obtido em string com o comando cpfcal[i].Tostring().Depois de convertido para string é possível converter para inteiro e realizar a
               multiplicação
                */
            //    Console.WriteLine(int.Parse(cpfcalc[i].ToString() ) *peso10);

               /*
               Fazemos a multiplicação de cade número do CPF pelo peso de 10 a 9 e guardamos o resultado na variável resultado.
                */
               resultado += int.Parse( cpfcalc[i].ToString()) * peso10;

               //Estamos realizando a decrementação da variável peso10, ou seja, retirando 1 a cada volta do laço
                peso10--; 
            }
            //    Console.WriteLine(resultado);

               //Obter o resultado e dividir por 11 e guardar o resto da divisão na vairável resto    
               resto = resultado % 11;

                //Se o resto da divisão for menor que 2 então o digito verificador do cpf será 0. Caso contrário o dígito será o resultado
                // da subtração de 11 pelo resto.
               if(resto < 2){
                 cpfcalc = cpfcalc+0;  
               }
               else{
                 cpfcalc = cpfcalc+(11-resto);  
               }
            //    Console.WriteLine(cpfcalc); 
            
               //Estamos zerando a variável resultado para iniciar o próximo cálculo
                
                resultado = 0;

                for(int i=0; i <= 9; i++){
                  resultado += int.Parse(cpfcalc[i].ToString())*peso11;
                  peso11--;  
                }

               resto = resultado % 11;

               if(resto < 2){
                   cpfcalc=cpfcalc + 0;
               }
               else{
                   cpfcalc =cpfcalc + (11-resto);
               }
            //    Console.WriteLine(cpfcalc);

            if(cpfus.Equals(cpfcalc)){
               
               Console.WriteLine("Seu cpf é válido!");
              
            }
                else{
                
                 Console.WriteLine("Seu cpf é inválido");


                }
           
        }
    }
}
