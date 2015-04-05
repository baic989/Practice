/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package vjezbazami1_3;

/**
 *
 * @author hrvoje
 */
public class VjezbaZaMI1_3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Adresa a1 = new Adresa("ulica1", "broj1", "grad1", "drzava1");
        Adresa a2 = new Adresa("ulica2", "broj2", "grad2", "drzava2");
        
        Student s1 = new Student("Pero", "Peric", a1);
        Student s2 = new Student("Ana", "Anic", a2);
        
        Profesor p1 = new Profesor("Marko", "Markic", a1);
        Profesor p2 = new Profesor("Netko", "Netkic", a2);
        
        Kolegij k1 = new Kolegij("Kolegij1", p1.getId());
        Kolegij k2 = new Kolegij("Kolegij2", p2.getId());
        
        s1.upisiKolegij(k1, k2);
        s2.upisiKolegij(k1, k2);
        
        System.out.println(s1.toString());
    }
    
}
