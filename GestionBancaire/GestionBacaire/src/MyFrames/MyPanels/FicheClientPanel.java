/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package MyFrames.MyPanels;

import GestionBancaire.ConnectionBD;
import java.awt.Image;
import java.awt.Toolkit;
import java.awt.image.BufferedImage;
import java.io.InputStream;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import javax.imageio.ImageIO;
import javax.swing.Icon;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;

/**
 *
 * @author asus pro
 */
public class FicheClientPanel extends javax.swing.JPanel {

    /**
     * Creates new form FicheClientPanel
     */
    public FicheClientPanel() {
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

        jLabel1 = new javax.swing.JLabel();
        cin_field = new javax.swing.JTextField();
        jButton1 = new javax.swing.JButton();
        nom_field = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        prenom_field = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        code_courant_field = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        code_epargne_field = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        solde_courant_field = new javax.swing.JTextField();
        solde_epargne_field = new javax.swing.JTextField();
        imageF = new javax.swing.JLabel();

        setBackground(new java.awt.Color(255, 255, 255));

        jLabel1.setForeground(new java.awt.Color(0, 153, 255));
        jLabel1.setText("CIN:");

        jButton1.setBackground(new java.awt.Color(0, 153, 255));
        jButton1.setFont(new java.awt.Font("Segoe UI", 1, 12)); // NOI18N
        jButton1.setForeground(new java.awt.Color(255, 255, 255));
        jButton1.setText("Rechercher");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        nom_field.setEditable(false);

        jLabel2.setForeground(new java.awt.Color(0, 153, 255));
        jLabel2.setText("Nom:");

        jLabel3.setForeground(new java.awt.Color(0, 153, 255));
        jLabel3.setText("Prenom:");

        prenom_field.setEditable(false);

        jLabel4.setForeground(new java.awt.Color(0, 153, 255));
        jLabel4.setText("Code compte courant:");

        code_courant_field.setEditable(false);

        jLabel5.setForeground(new java.awt.Color(0, 153, 255));
        jLabel5.setText("Code compte epargne:");

        code_epargne_field.setEditable(false);

        jLabel6.setForeground(new java.awt.Color(0, 153, 255));
        jLabel6.setText("Solde:");

        jLabel7.setForeground(new java.awt.Color(0, 153, 255));
        jLabel7.setText("Solde:");

        solde_courant_field.setEditable(false);

        solde_epargne_field.setEditable(false);
        solde_epargne_field.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                solde_epargne_fieldActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(26, 26, 26)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel1)
                        .addGap(25, 25, 25)
                        .addComponent(cin_field, javax.swing.GroupLayout.PREFERRED_SIZE, 275, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addGroup(layout.createSequentialGroup()
                            .addComponent(jLabel2)
                            .addGap(18, 18, 18)
                            .addComponent(nom_field, javax.swing.GroupLayout.PREFERRED_SIZE, 156, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGap(74, 74, 74)
                            .addComponent(jLabel3))
                        .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                .addGroup(layout.createSequentialGroup()
                                    .addGap(3, 3, 3)
                                    .addComponent(jLabel5)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addComponent(code_epargne_field, javax.swing.GroupLayout.PREFERRED_SIZE, 77, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addGroup(layout.createSequentialGroup()
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                        .addGroup(layout.createSequentialGroup()
                                            .addGap(32, 32, 32)
                                            .addComponent(imageF, javax.swing.GroupLayout.PREFERRED_SIZE, 87, javax.swing.GroupLayout.PREFERRED_SIZE))
                                        .addGroup(layout.createSequentialGroup()
                                            .addComponent(jLabel4)
                                            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
                                    .addGap(45, 45, 45)
                                    .addComponent(code_courant_field, javax.swing.GroupLayout.PREFERRED_SIZE, 77, javax.swing.GroupLayout.PREFERRED_SIZE)))
                            .addGap(27, 27, 27))))
                .addGap(3, 3, 3)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(32, 32, 32)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jButton1, javax.swing.GroupLayout.PREFERRED_SIZE, 127, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(prenom_field)))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel7)
                            .addComponent(jLabel6))
                        .addGap(39, 39, 39)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(solde_courant_field, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 74, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(solde_epargne_field, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 74, javax.swing.GroupLayout.PREFERRED_SIZE))))
                .addGap(19, 19, 19))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(39, 39, 39)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(cin_field, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jButton1))
                .addGap(33, 33, 33)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(nom_field, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel2)
                    .addComponent(jLabel3)
                    .addComponent(prenom_field, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(imageF, javax.swing.GroupLayout.PREFERRED_SIZE, 79, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel4)
                    .addComponent(code_courant_field, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(solde_courant_field, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel6))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 35, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel5)
                    .addComponent(code_epargne_field, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(solde_epargne_field, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel7))
                .addGap(43, 43, 43))
        );
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        String cin = cin_field.getText();

         //clear 
         nom_field.setText("");
         prenom_field.setText("#");
         code_courant_field.setText("#");
        solde_courant_field.setText("#");
        code_epargne_field.setText("#");
        solde_epargne_field.setText("#");
        
        
        try {
            ConnectionBD conn = new ConnectionBD();
            String sql = "select * from clients where cin_client=?";
            PreparedStatement preparedstm = conn.initRequetePreparee(sql, true, cin);
            ResultSet rs = preparedstm.executeQuery();

            byte[] image = null;
            if (rs.next()) {
                 image = rs.getBytes("image");  
                Image img = Toolkit.getDefaultToolkit().createImage(image);
                 ImageIcon icon =new ImageIcon(img);
                imageF.setIcon(icon);
                
                int id_client = rs.getInt("id_client");
                nom_field.setText(rs.getString("nom_client"));
                prenom_field.setText(rs.getString("prenom_client"));

                sql = "select * from comptes where id_client= ?";
                PreparedStatement prpstm = conn.initRequetePreparee(sql, true, rs.getInt("id_client"));
                ResultSet rsc = prpstm.executeQuery();
                while (rsc.next()) {
                    double solde = rsc.getDouble("solde_compte");
                    sql = "select * from comptes_courants where code_compte=?";
                    prpstm = conn.initRequetePreparee(sql, true, rsc.getInt("code_compte"));
                    ResultSet rscc = prpstm.executeQuery();
                    if (rscc.next()) {
                        //compte courant
                        code_courant_field.setText(rsc.getString("code_compte"));
                        solde_courant_field.setText(String.valueOf(solde));

                    } else { //comptes epargne
                        code_epargne_field.setText(rsc.getString("code_compte"));
                        solde_epargne_field.setText(String.valueOf(solde));
                    }
                }
            } else {
                JOptionPane.showMessageDialog(null, "cin inexistant");
            }

            conn.disconnect();
        } catch (Exception e) {
            System.err.println(e);
        }
        
    }//GEN-LAST:event_jButton1ActionPerformed

    public  void deplace(int i)
    {
        try{
            nom_field.setText(VisionnerTransactionsPanel.model.getValueAt(i, 0).toString());
            prenom_field.setText(VisionnerTransactionsPanel.model.getValueAt(i, 1).toString());
        }catch(Exception e){
            System.err.println(e);
            JOptionPane.showMessageDialog(null, "erreur de deplacement: aa"+e.getLocalizedMessage());
        }
        
    }
    
    private void solde_epargne_fieldActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_solde_epargne_fieldActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_solde_epargne_fieldActionPerformed


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTextField cin_field;
    private javax.swing.JTextField code_courant_field;
    private javax.swing.JTextField code_epargne_field;
    private javax.swing.JLabel imageF;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JTextField nom_field;
    private javax.swing.JTextField prenom_field;
    private javax.swing.JTextField solde_courant_field;
    private javax.swing.JTextField solde_epargne_field;
    // End of variables declaration//GEN-END:variables
}