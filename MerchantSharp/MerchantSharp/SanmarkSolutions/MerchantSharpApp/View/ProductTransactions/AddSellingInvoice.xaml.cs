﻿using MerchantSharp.SanmarkSolutions.MerchantSharpApp.Controler;
using MerchantSharp.SanmarkSolutions.MerchantSharpApp.Model.Entities;
using MerchantSharp.SanmarkSolutions.MerchantSharpApp.View.Modules;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MerchantSharp.SanmarkSolutions.MerchantSharpApp.View.ProductTransactions {
	/// <summary>
	/// Interaction logic for AddSellingInvoice.xaml
	/// </summary>
	public partial class AddSellingInvoice : UserControl {

		private SellingInvoiceManagerControler sellingInvoiceManagerControler = null;

		private bool isLoadedUI = false;
		public bool IsLoadedUI {
			get { return isLoadedUI; }
			set { isLoadedUI = value; }
		}

		private DataTable selectedItems = null;
		public DataTable SelectedItems {
			get { return selectedItems; }
			set { selectedItems = value; }
		}

		private ItemFinder itemFinder = null;
		public ItemFinder ItemFinder {
			get { return itemFinder; }
			set { itemFinder = value; }
		}

		private PaymentSection paymentSection = null;
		public PaymentSection PaymentSection {
			get { return paymentSection; }
			set { paymentSection = value; }
		}

		private Item selectedItem = null;
		internal Item SelectedItem {
			get { return selectedItem; }
			set { selectedItem = value; }
		}

		private DataTable dataTableSellingPrices = null;
		public DataTable DataTableSellingPrices {
			get { return dataTableSellingPrices; }
			set { dataTableSellingPrices = value; }
		}

		private List<Discount> discountList = null;
		internal List<Discount> DiscountList {
			get { return discountList; }
			set { discountList = value; }
		}

		private bool isItemUpdateMode = false;
		public bool IsItemUpdateMode {
			get { return isItemUpdateMode; }
			set { isItemUpdateMode = value; }
		}

		private SellingInvoice sellingInvoice = null;
		internal SellingInvoice SellingInvoice {
			get { return sellingInvoice; }
			set { sellingInvoice = value; }
		}

		private int updateItemSelectedIndex = -1;
		public int UpdateItemSelectedIndex {
			get { return updateItemSelectedIndex; }
			set { updateItemSelectedIndex = value; }
		}

		private int invoiceId = 0;
		public int InvoiceId {
			get { return invoiceId; }
			set { invoiceId = value; }
		}

		private bool isInvoiceUpdateMode = false;
		public bool IsInvoiceUpdateMode {
			get { return isInvoiceUpdateMode; }
			set { isInvoiceUpdateMode = value; }
		}

		public AddSellingInvoice() {
			InitializeComponent();
			sellingInvoiceManagerControler = new SellingInvoiceManagerControler(this);
		}

		public AddSellingInvoice(int invoiceId) {
			InitializeComponent();
			this.invoiceId = invoiceId;
			isInvoiceUpdateMode = true;
			sellingInvoiceManagerControler = new SellingInvoiceManagerControler(this);
		}

		private void UserControl_Loaded(object sender, RoutedEventArgs e) {
			sellingInvoiceManagerControler.UserControl_Loaded();
		}

		private void textBox_itemId_selectItem_TextChanged(object sender, TextChangedEventArgs e) {
			sellingInvoiceManagerControler.textBox_itemId_selectItem_TextChanged();
		}

		private void textBox_code_selectItem_KeyDown(object sender, KeyEventArgs e) {
			if(e.Key == Key.Enter) {
				sellingInvoiceManagerControler.textBox_code_selectItem_KeyDown();
			}
		}

		private void radioButton_unit_sellingMode_Checked(object sender, RoutedEventArgs e) {
			sellingInvoiceManagerControler.sellingModeRadioButtonClicked();
		}

		private void radioButton_pack_sellingMode_Checked(object sender, RoutedEventArgs e) {
			sellingInvoiceManagerControler.sellingModeRadioButtonClicked();
		}

		private void comboBox_sellingPrice_selectItem_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			sellingInvoiceManagerControler.sellingPriceChanged();
		}
		private void comboBox_sellingPrice_selectItem_TextChanged(object sender, TextChangedEventArgs e) {
			sellingInvoiceManagerControler.sellingPriceChanged();
		}

		private void textBox_discount_selectItem_TextChanged(object sender, TextChangedEventArgs e) {
			sellingInvoiceManagerControler.textBox_discount_selectItem_TextChanged();
		}

		private void textBox_sellingQuantity_selectItem_TextChanged(object sender, TextChangedEventArgs e) {
			sellingInvoiceManagerControler.textBox_sellingQuantity_selectItem_TextChanged();
		}

		private void button_add_selectItem_Click(object sender, RoutedEventArgs e) {
			sellingInvoiceManagerControler.button_add_selectItem_Click();
		}

		private void dataGrid_selectedItems_selectedItems_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
			sellingInvoiceManagerControler.dataGrid_selectedItems_selectedItems_MouseDoubleClick();
		}

		private void comboBox_sellingPrice_selectItem_KeyDown(object sender, KeyEventArgs e) {
			if(e.Key == Key.Enter) {
				sellingInvoiceManagerControler.button_add_selectItem_Click();
			}
		}

		private void textBox_sellingQuantity_selectItem_KeyDown(object sender, KeyEventArgs e) {
			if(e.Key == Key.Enter) {
				sellingInvoiceManagerControler.button_add_selectItem_Click();
			}
		}

		private void textBox_discount_selectItem_KeyDown(object sender, KeyEventArgs e) {
			if(e.Key == Key.Enter) {
				sellingInvoiceManagerControler.button_add_selectItem_Click();
			}
		}

		private void textBox_marketReturn_selectItem_KeyDown(object sender, KeyEventArgs e) {
			if(e.Key == Key.Enter) {
				sellingInvoiceManagerControler.button_add_selectItem_Click();
			}
		}

		private void textBox_goodReturn_selectItem_KeyDown(object sender, KeyEventArgs e) {
			if(e.Key == Key.Enter) {
				sellingInvoiceManagerControler.button_add_selectItem_Click();
			}
		}

		private void textBox_wasteReturn_selectItem_KeyDown(object sender, KeyEventArgs e) {
			if(e.Key == Key.Enter) {
				sellingInvoiceManagerControler.button_add_selectItem_Click();
			}
		}

		private void UserControl_KeyDown(object sender, KeyEventArgs e) {
			sellingInvoiceManagerControler.UserControl_KeyDown(e);
		}

		private void checkBox_quickPay_selectedItems_Click(object sender, RoutedEventArgs e) {
			sellingInvoiceManagerControler.checkBox_quickPay_selectedItems_Click();
		}

		private void button_saveAndPrint_Click(object sender, RoutedEventArgs e) {
			sellingInvoiceManagerControler.button_saveAndPrint_Click();
		}

		private void button_saveInvoice_Click(object sender, RoutedEventArgs e) {
			sellingInvoiceManagerControler.button_saveInvoice_Click();
		}

		private void textBox_cash_selectedItems_TextChanged(object sender, TextChangedEventArgs e) {
			sellingInvoiceManagerControler.textBox_cash_selectedItems_TextChanged();
		}

		private void button_resetUI_Click(object sender, RoutedEventArgs e) {
			sellingInvoiceManagerControler.button_resetUI_Click();
		}

		private void textBox_discount_selectedItems_TextChanged(object sender, TextChangedEventArgs e) {
			sellingInvoiceManagerControler.textBox_discount_selectedItems_TextChanged();
		}

	}
}
