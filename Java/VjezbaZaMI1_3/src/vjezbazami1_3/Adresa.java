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
public class Adresa {
    private String ulica;
    private String kBroj;
    private String grad;
    private String drzava;
    
    public Adresa(String ulica, String kBroj, String grad, String drzava){
        this.ulica = ulica;
        this.kBroj = kBroj;
        this.grad = grad;
        this.drzava = drzava;
    }
}
