/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jquickpad;

import java.io.*;
import javax.swing.UIManager;

/**
 *
 * @author Shubham
 */
public class QuickPadUI extends javax.swing.JFrame {
public static void saveFile(javax.swing.JFileChooser fileChooser, 
                               javax.swing.JTextPane editor)
{
    try (FileWriter writer = new FileWriter(fileChooser.getSelectedFile()))
    {
    //try to save file
        writer.write(editor.getText());
    }
    catch (IOException e)
    {
      editor.setText("Unable to save file. Detailed information \n"+ 
                        e.getMessage());
    }
    editor.setText( "File succesfully saved");
}
    /**
     * Creates new form QuickPadUI
     */
    public QuickPadUI() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        fileSave = new javax.swing.JFileChooser();
        fileOpen = new javax.swing.JFileChooser();
        textBox_ScrollPanel = new javax.swing.JScrollPane();
        textBox = new javax.swing.JTextPane();
        save_Button = new javax.swing.JButton();
        open_Button = new javax.swing.JButton();
        exit_Button = new javax.swing.JButton();

        fileSave.setDialogType(javax.swing.JFileChooser.SAVE_DIALOG);
        fileSave.setApproveButtonToolTipText("");

        fileOpen.setApproveButtonToolTipText("");

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("QuickPad");
        setAlwaysOnTop(true);
        setCursor(new java.awt.Cursor(java.awt.Cursor.DEFAULT_CURSOR));
        setLocationByPlatform(true);

        textBox_ScrollPanel.setViewportView(textBox);

        save_Button.setText("Save");
        save_Button.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                save_ButtonActionPerformed(evt);
            }
        });

        open_Button.setText("Open");

        exit_Button.setText("Exit");
        exit_Button.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                exit_ButtonActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(textBox_ScrollPanel)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(exit_Button)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 207, Short.MAX_VALUE)
                        .addComponent(open_Button)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(save_Button)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(textBox_ScrollPanel, javax.swing.GroupLayout.DEFAULT_SIZE, 244, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(save_Button)
                    .addComponent(open_Button, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(exit_Button))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void save_ButtonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_save_ButtonActionPerformed
        // TODO add your handling code here:
        fileSave.showDialog(this, null);
        saveFile(fileSave,textBox);
        
        /* Uncoment this line to test whether FileChooser returns the path of 
        correct file */
        //textBox.setText(textBox.getText()+"\n"+
        //fileChooser.getSelectedFile().toString());
    }//GEN-LAST:event_save_ButtonActionPerformed

    private void exit_ButtonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_exit_ButtonActionPerformed
        // TODO add your handling code here:
        System.exit(0);    
    }//GEN-LAST:event_exit_ButtonActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        try {
             UIManager.setLookAndFeel(
            UIManager.getSystemLookAndFeelClassName());
                
            
        } catch (ClassNotFoundException | InstantiationException | 
                IllegalAccessException | javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(QuickPadUI.class.getName()).log
                    (java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new QuickPadUI().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton exit_Button;
    private javax.swing.JFileChooser fileOpen;
    private javax.swing.JFileChooser fileSave;
    private javax.swing.JButton open_Button;
    private javax.swing.JButton save_Button;
    private javax.swing.JTextPane textBox;
    private javax.swing.JScrollPane textBox_ScrollPanel;
    // End of variables declaration//GEN-END:variables
}
