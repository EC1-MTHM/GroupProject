<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="EC1_ashion.ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Preloder -->
    <div id="preloder">
        <div class="loader"></div>
    </div>

    <div id="ShoppingCartTitle" runat="server" class="ContentHead">
        <h1>Shopping Cart</h1>
    </div>
    <!-- Shop Cart Section Begin -->
    <section class="shop-cart spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="shop__cart__table">
                        <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="False"
                            ShowFooter="True" GridLines="Vertical" CellPadding="4"
                            ItemType="EC1_ashion.Models.CartItem" SelectMethod="GetShoppingCartItems"
                            CssClass="table table-striped table-bordered">
                            <Columns>
                                <asp:BoundField DataField="ProductID" HeaderText="ID"
                                    SortExpression="ProductID" />
                                <asp:BoundField DataField="Product.ProductName" HeaderText="Name" />
                                <asp:BoundField DataField="Product.UnitPrice" HeaderText="Price (each)"
                                    DataFormatString="{0:c}" />
                                <asp:TemplateField HeaderText="Quantity">
                                    <ItemTemplate>
                                        <asp:TextBox ID="PurchaseQuantity" Width="40"
                                            runat="server" Text="<%#: Item.Quantity %>"></asp:TextBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Item Total">
                                    <ItemTemplate>
                                        <%#: String.Format("{0:c} ",((Convert.ToDouble(Item.Quantity)) * Convert.ToDouble(Item.Product.UnitPrice)))%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Remove Item">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="Remove" runat="server"></asp:CheckBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>

                        <div class="row">
                            <div class="col-lg-6 col-md-6 col-sm-6">
                                <div class="cart__btn">
                                    <a href="ProductList.aspx">Continue Shopping</a>
                                </div>
                            </div>
                            <div class="col-lg-6 col-md-6 col-sm-6">
                                <div class="cart__btn update__btn">
                                    <asp:Button ID="UpdateBtn" runat="server" Text="Update cart" CssClass="icon_loading" OnClick="UpdateBtn_Click" />
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-lg-6">
                            </div>
                            <div class="col-lg-4 offset-lg-2">
                                <div class="cart__total__procced">
                                    <h6>Cart total
                                    </h6>
                                    <ul>
                                        <li>Subtotal: 
                                            <span>
                                                <asp:Label ID="Label1" runat="server" EnableViewState="false"></asp:Label>
                                            </span>
                                        </li>
                                        <li>Order Total:
                                            <span>
                                                <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
                                            </span>
                                        </li>
                                    </ul>
                                    <a href="#" class="primary-btn">Proceed to checkout</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- Shop Cart Section End -->
</asp:Content>
