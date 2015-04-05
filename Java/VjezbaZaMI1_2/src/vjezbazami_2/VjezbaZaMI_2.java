/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package vjezbazami_2;

import java.util.Scanner;

/**
 *
 * @author hrvoje
 */
public class VjezbaZaMI_2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        String unos;
        Scanner s = new Scanner(System.in);
        
        System.out.println("Unesite rijec: ");
        unos = s.next();
        
        String provjeraPalindroma = new StringBuilder(unos).reverse().toString();
        
        if(unos.equals(provjeraPalindroma)){
            System.out.println("Rijec je palindrom");
        }
        else{
            System.out.println("Rijec nije palindrom");
        }
    }
    
}
