﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopClassLibrary;

namespace WebShop
{
    public partial class WebProductControl : System.Web.UI.UserControl
    {
        private static int _classID;
        private int _id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cart"] == null)
            {
                Session.Add("cart", new Cart());
            }

            _id = ++_classID;

            RequiredFieldValidator1.ValidationGroup = _id.ToString();
            RequiredFieldValidator2.ValidationGroup = _id.ToString();
            RequiredFieldValidator3.ValidationGroup = _id.ToString();
            CompareValidator1.ValidationGroup = _id.ToString();
            btnAction.ValidationGroup = _id.ToString();
        }

        public void showProduct(Product p)
        {
            lblID.Text = p.ID.ToString();
            txtName.Text = p.Name;
            txtPrice.Text = p.Price.ToString();
            txtDate.Text = p.ExpirationDate.ToString();

            txtName.Enabled = false;
            txtPrice.Enabled = false;
            txtDate.Enabled = false;

            btnAction.CommandArgument = p.ID.ToString();
            btnAction.Text = "Add to cart";
            btnAction.CausesValidation = false;
            btnAction.Click += btnAction_Click;
        }

        public void addNewProduct()
        {
            btnAction.Text = "Add new item";
            btnAction.Click += btnActionAdd_Click;
        }

        public void editProduct(Product p)
        {
            lblID.Text = p.ID.ToString();
            txtName.Text = p.Name;
            txtPrice.Text = p.Price.ToString();

            btnAction.CommandArgument = p.ID.ToString();
            btnAction.Text = "Edit item";

            btnAction.Click += btnActionEdit_Click;
        }

        private void btnActionEdit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            int id = int.Parse(btn.CommandArgument);
            string name = txtName.Text;
            double price = double.Parse(txtPrice.Text);
            DateTime date = DateTime.Parse(txtDate.Text);
            ProductsRepo.updateProductById(id, name, price, date);
        }

        private void btnActionAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Name = txtName.Text;
            p.Price = Convert.ToDouble(txtPrice.Text);
            p.ExpirationDate = DateTime.Parse(txtDate.Text);

            ProductsRepo.addProduct(p);

            // Redirect to the same page
            Response.Redirect(Request.RawUrl);
        }

        void btnAction_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Product p = ProductsRepo.getProductById(int.Parse(btn.CommandArgument));
            Cart c = Session["cart"] as Cart;

            c.addProduct(p);

            ProductsRepo.removeProductById(int.Parse(btn.CommandArgument));

            Response.Redirect(Request.RawUrl);
        }
    }
}