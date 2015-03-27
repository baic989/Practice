/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package gameoflife;

import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author hrvoje
 */
public class GameOfLife {
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        final int size = 30;
        
        // The world is actually flat :O
        boolean[][] worldMatrix = new boolean[size][size];
        
        // Life found at
        worldMatrix[2][2] = true;
        worldMatrix[2][3] = true;
        worldMatrix[3][2] = true;
        worldMatrix[20][20] = true;
        worldMatrix[20][21] = true;
        worldMatrix[21][20] = true;
        
        while(true){
//            try {
//                Runtime.getRuntime().exec("clear");
//            } catch (IOException ex) {
//                Logger.getLogger(GameOfLife.class.getName()).log(Level.SEVERE, null, ex);
//            }
            
            System.out.flush();
            
            Draw(LetTheGameBegin(worldMatrix, size), size);
            
            try {
                Thread.sleep(1000);
            } catch (InterruptedException ex) {
                Logger.getLogger(GameOfLife.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
    }
    
    private static void Draw(boolean[][] world, int size){
        for (int i = 0; i < size; i++) {
                
                for (int j = 0; j < size; j++) {
                    if(world[i][j] == true){
                        System.out.print("*");
                    }
                    else{
                        System.out.print(" ");
                    }
                }
                System.out.println("");
            }
    }
    
    private static boolean[][] LetTheGameBegin(boolean[][] world, int size){
        
        int counter;
        
        for (int i = 0; i < size; i++) {
            counter = 0;
            
            for (int j = 0; j < size; j++) {
                
                if(j < size - 1)
                    if(world[i][j+1] == true)
                        counter++;
                
                if(j > 0)
                    if(world[i][j-1] == true)
                        counter++;
                
                if(i > 0)
                    if(world[i-1][j] == true)
                        counter++;
                
                if(i < size - 1)
                    if(world[i+1][j] == true)
                        counter++;
                
                if(i > 0 && j > 0)
                    if(world[i-1][j-1] == true)
                        counter++;
                
                if(i != 0 && j < size - 1)
                    if(world[i-1][j+1] == true)
                        counter++;
                
                if(i < size - 1 && j > 0)
                    if(world[i+1][j-1] == true)
                        counter++;
                
                if(i < size - 1 && j < size - 1)
                    if(world[i+1][j+1] == true)
                        counter++;
                
                // Check which should live and die
                if(counter > 3 || counter < 2)
                    world[i][j] = false;
                
                if(counter >= 2 && counter <= 3)
                    world[i][j] = true;
            }
        }
        
        return world;
    }
}
