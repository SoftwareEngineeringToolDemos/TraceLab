/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package tracelab.component.filetemplate;

import javax.swing.JPanel;

public final class ComponentDefinitionVisualPanel1 extends JPanel {

    /**
     * Creates new form ComponentDefinitionVisualPanel1
     */
    public ComponentDefinitionVisualPanel1() {
        initComponents();
    }

    @Override
    public String getName() {
        return "Component definition";
    }
    
    public String getComponentLabel() {
        return componentLabelField.getText();
    }

    public String getDescritpion() {
        return descriptionField.getText();
    }
    
    public boolean shouldIncludeSampleIO() {
        return includeSampleIO.isSelected();
    }
        
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jTextField1 = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        componentLabelField = new javax.swing.JTextField();
        jScrollPane1 = new javax.swing.JScrollPane();
        descriptionField = new javax.swing.JTextArea();
        includeSampleIO = new javax.swing.JCheckBox();

        jTextField1.setText(org.openide.util.NbBundle.getMessage(ComponentDefinitionVisualPanel1.class, "ComponentDefinitionVisualPanel1.jTextField1.text")); // NOI18N

        org.openide.awt.Mnemonics.setLocalizedText(jLabel1, org.openide.util.NbBundle.getMessage(ComponentDefinitionVisualPanel1.class, "ComponentDefinitionVisualPanel1.jLabel1.text")); // NOI18N
        jLabel1.setToolTipText(org.openide.util.NbBundle.getMessage(ComponentDefinitionVisualPanel1.class, "ComponentDefinitionVisualPanel1.jLabel1.toolTipText")); // NOI18N

        org.openide.awt.Mnemonics.setLocalizedText(jLabel2, org.openide.util.NbBundle.getMessage(ComponentDefinitionVisualPanel1.class, "ComponentDefinitionVisualPanel1.jLabel2.text")); // NOI18N
        jLabel2.setToolTipText(org.openide.util.NbBundle.getMessage(ComponentDefinitionVisualPanel1.class, "ComponentDefinitionVisualPanel1.jLabel2.toolTipText")); // NOI18N

        componentLabelField.setText(org.openide.util.NbBundle.getMessage(ComponentDefinitionVisualPanel1.class, "ComponentDefinitionVisualPanel1.componentLabelField.text")); // NOI18N

        descriptionField.setColumns(20);
        descriptionField.setRows(5);
        jScrollPane1.setViewportView(descriptionField);

        org.openide.awt.Mnemonics.setLocalizedText(includeSampleIO, org.openide.util.NbBundle.getMessage(ComponentDefinitionVisualPanel1.class, "ComponentDefinitionVisualPanel1.includeSampleIO.text")); // NOI18N

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel2)
                    .addComponent(jLabel1))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(includeSampleIO)
                        .addContainerGap(19, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(componentLabelField)
                            .addComponent(jScrollPane1))
                        .addContainerGap(14, javax.swing.GroupLayout.PREFERRED_SIZE))))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(componentLabelField, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel2)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(includeSampleIO)
                .addContainerGap(132, Short.MAX_VALUE))
        );
    }// </editor-fold>//GEN-END:initComponents

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTextField componentLabelField;
    private javax.swing.JTextArea descriptionField;
    private javax.swing.JCheckBox includeSampleIO;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTextField jTextField1;
    // End of variables declaration//GEN-END:variables
}
