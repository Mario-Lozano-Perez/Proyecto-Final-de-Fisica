using fruslib;
using Proyecto_Final_de_Fisica.DatabaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_de_Fisica.Frms
{
    public partial class FormManageUserValues : Form
    {
        private UserListForm HeadForm;
        private Boolean IsEditing = false;
        private User UserToModify;

        public FormManageUserValues()
        {
            InitializeComponent();
            
        }

        public FormManageUserValues(UserListForm headForm)
        {
            InitializeComponent();
            this.HeadForm = headForm;
        }

        public FormManageUserValues(UserListForm headForm, User userToModify)
        {
            InitializeComponent();
            this.HeadForm = headForm;
            this.UserToModify = userToModify;
            this.IsEditing = true;
            lbl_UsrMod.Text = "Editando Usuario";
            txt_CI.Value = this.UserToModify.Ci;
            txt_CI.Enabled = false;
            txt_Name.Value = this.UserToModify.Name;
            txt_Password.Value = this.UserToModify.Password;
            if(this.UserToModify.Level == 1)
            {
                chk_Admin.IsSelected = true;
            }
            else
            {
                chk_Admin.IsSelected = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Apply_Click(object sender, EventArgs e)
        {
            if (!this.IsEditing)
            {
                try
                {
                    InsertUser();
                }catch(Exception err)
                {
                    throw err;
                }
            }
            else
            {
                try
                {
                    UpdateUser();
                }
                catch (Exception err)
                {
                    throw err;
                }
            }
        }

        private void InsertUser()
        {
            if (txt_CI.Value.Length < 11)
            {
                txt_CI.IsWrong();
            }
            else if (txt_Name.Value == String.Empty)
            {
                txt_Name.IsWrong();
            }
            else if (txt_Password.Value == String.Empty)
            {
                txt_Password.IsWrong();
            }
            else
            {
                try
                {
                    User userToCreate = new User();

                    userToCreate.Ci = txt_CI.Value;
                    userToCreate.Name = txt_Name.Value;
                    userToCreate.Password = Cipher.CesarCifrar(txt_Password.Value, 5);
                    if (chk_Admin.IsSelected)
                    {
                        userToCreate.Level = 1;
                    }
                    else
                    {
                        userToCreate.Level = 0;
                    }


                    userToCreate.Insert();
                    this.HeadForm.ReadData();
                    this.Dispose();
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
        }

        private void UpdateUser()
        {
            if (txt_CI.Value.Length < 11)
            {
                txt_CI.IsWrong();
            }
            else if (txt_Name.Value == String.Empty)
            {
                txt_Name.IsWrong();
            }
            else if (txt_Password.Value == String.Empty)
            {
                txt_Password.IsWrong();
            }
            else
            {
                try
                {
                    User userToCreate = new User();

                    userToCreate.Ci = txt_CI.Value;
                    userToCreate.Name = txt_Name.Value;
                    userToCreate.Password = Cipher.CesarCifrar(txt_Password.Value, 5);
                    if (chk_Admin.IsSelected)
                    {
                        userToCreate.Level = 1;
                    }
                    else
                    {
                        userToCreate.Level = 0;
                    }


                    userToCreate.Update();
                    this.HeadForm.ReadData();
                    this.Dispose();
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
        }


    }
}
