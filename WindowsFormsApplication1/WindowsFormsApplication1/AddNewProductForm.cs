using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltraShopBd.Entites;
using UltraShopBd.DataAccess;

namespace WindowsFormsApplication1
{
    public partial class AddNewProductForm : Form
    {


        AddNewProduct allInfo = new AddNewProduct();
        AddNewProductDA getCat = new AddNewProductDA();
        public AddNewProductForm()
        {
            InitializeComponent();

            FillCatCombo();
            FillColorCombo();
            HideCategory();
            FillConditionCombo();
        
            
        
        }

      

     
        private void FillConditionCombo()
        {

            List<AddNewProduct> condition = new List<AddNewProduct>();

            AddNewProductDA getCon = new AddNewProductDA();

            condition = getCat.GetName("condition");
            foreach (AddNewProduct add in condition)
            {

                conditionComboBox.Items.Add(add.color);
            }



        }
        private void  HideCategory()
        {
            subCategoryLabel1.Visible = false;
            subCategoryLabel2.Visible = false;
            subCategoryComboBox1.Visible = false;
            subCategoryComboBox2.Visible = false;
          

        }
        private void FillCatCombo()
        {

            List<AddNewProduct> categories = new List<AddNewProduct>();

            AddNewProductDA getCat = new AddNewProductDA();
           

            categories = getCat.GetName("category");
            foreach (AddNewProduct add in categories)
            {
       
                categoryComboBox.Items.Add(add.color);
            }
        }
           
        private void categoryLbel_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (colorComboBox.SelectedIndex > -1)
            {
                colorListBox.ForeColor = System.Drawing.Color.Black;

                colorListBox.Items.Add(colorComboBox.Text);

                colorComboBox.Items.Remove(colorComboBox.Text);
                colorComboBox.Text = String.Empty;
            }
        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {
           
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subCategoryLabel1.Visible = true;
            subCategoryComboBox1.Visible = true;
            string selectedCategory= categoryComboBox.Text;
            subCategoryComboBox1.Items.Clear();
            subCategoryComboBox1.Text = string.Empty;

            subCategoryComboBox2.Items.Clear();
            subCategoryComboBox2.Text = string.Empty;

           allInfo.catId = getCat.GetId( "category","cat_name",selectedCategory);
            FillSubCatCombo1(selectedCategory );

        }


        private void FillSubCatCombo1(string selectedCategory)
        {

            List<AddNewProduct> subCategories = new List<AddNewProduct>();
        
            subCategories = getCat.GetSubCategory("sub_category","cat_id", allInfo.catId);

            foreach (AddNewProduct showData in subCategories)
            {
                subCategoryComboBox1.Items.Add(showData.subCategory1);

            }
       }

     

        private void subCategoryComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            subCategoryLabel2.Visible = true;
            subCategoryComboBox2.Visible = true;
            subCategoryComboBox2.Items.Clear();
            subCategoryComboBox2.Text = string.Empty;
            string selectedSubCategory = subCategoryComboBox1.Text;
            allInfo.subCatId1 = getCat.GetId("sub_category", "sub_cat_name", selectedSubCategory);
            
            FillSubCatCombo2(selectedSubCategory);
        }

        private void FillSubCatCombo2(string selectedCategory)
        {
            List<AddNewProduct> subSubCategories = new List<AddNewProduct>();

            subSubCategories = getCat.GetSubCategory("sub_sub_category", "sub_cat_id", allInfo.subCatId1);
            foreach (AddNewProduct showData in subSubCategories)
            {
                subCategoryComboBox2.Items.Add(showData.subCategory1);

            }
        }

        public void FillColorCombo()
        {

            List<AddNewProduct> colorList = new List<AddNewProduct>();

            colorList = getCat.GetName("color");
            foreach (AddNewProduct showData in colorList)
            {
               colorComboBox.Items.Add(showData.color);

            }
        
        
        }

        private void subCategoryComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           string selectedSubCategory2 = subCategoryComboBox2.Text;
           allInfo.subCatId2 = getCat.GetId("sub_sub_category", "sub_sub_cat_name", selectedSubCategory2);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameTextBox.MaxLength = 49;
            
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCondition = conditionComboBox.Text;
            allInfo.conditionId = getCat.GetId("condition", "condition_name", selectedCondition);
        }

        private void colorComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void delectButton_Click(object sender, EventArgs e)
        {
            if (colorListBox.SelectedIndex > -1)
            {
                string color = colorListBox.GetItemText(colorListBox.SelectedItem);
                colorComboBox.Items.Add(color);
                colorListBox.Items.Remove(colorListBox.SelectedItem);
         
            }
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            allInfo.name = nameTextBox.Text;
            int nameLenth =allInfo.name.Length;
            int flag = 1;
         

             string message=" ";

             if (nameLenth == 0 && nameLenth > 49)
            {

                message += "product name or name >50\n";
                flag = 0;
            }
            else
            {
                allInfo.name = nameTextBox.Text;
                allInfo.nameId = getCat.GetId("products", "product_name", allInfo.name);
                if(allInfo.nameId!=-1)
                {
                    flag = 0;
                    message += "This name allready used\n";
                }

            }

            if(categoryComboBox.SelectedIndex == -1)
            {
                flag = 0;

                message += "please select category\n";
            }

            if (colorListBox.Items.Count == 0)
            {
                flag = 0;
                message += "Please select color \n";
            }

            if (conditionComboBox.SelectedIndex == -1)
            {
                flag = 0;
                message += "Please select condition \n";
            }
            
            if(descriptionTextBox.TextLength==0)
            {
                flag = 0;
                message += "Please input product discription \n";

            }

            if(flag==0)
            {
                

                MessageBox.Show(message);
            }
            else
            {  
             
                
                foreach(string item in colorListBox.Items)
                {
                    allInfo.color += item.ToString()+" , ";

                }
                

                getCat.InserData(allInfo);

                nameTextBox.Text = "";
                colorListBox.Text = "";
                descriptionTextBox.Text = "";
                

                MessageBox.Show("Product upload successfuly");
            }
        

        }

        private void discriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            allInfo.description = descriptionTextBox.Text;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
           
    }
}
