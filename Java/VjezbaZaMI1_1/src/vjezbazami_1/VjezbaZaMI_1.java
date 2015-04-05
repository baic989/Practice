/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package vjezbazami_1;

import java.util.Scanner;

/**
 *
 * @author hrvoje
 */
public class VjezbaZaMI_1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        boolean provjera = true;
        String izbor;
        Scanner s = new Scanner(System.in);
        int broj;
        int suma;
        
        while (provjera){
            suma = 0;
            System.out.println("Unesite broj: ");
            broj = s.nextInt();
            
            try{
                for(int i = 1; i <= broj; i++){
                    if(broj % i == 0){
                        suma += i;
                    }
                }
                
                System.out.println("Suma djelitelja upisanog broja: " + suma);
            }
            catch(Exception e){
                System.out.println(e);
            }
            
            System.out.println("Unesti jos brojeva? (y/n): ");
            izbor = s.next();
            
            if("n".equals(izbor) || "no".equals(izbor)){
                provjera = false;
            }
        }
    }
    
}
