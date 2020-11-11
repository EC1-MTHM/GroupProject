<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="EC1_ashion.ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Product Details Section Begin -->
    <section class="product-details spad">
        <div class="container">
            <div class="row">
                <asp:FormView ID="productDetail" runat="server"
                    ItemType="EC1_ashion.Models.Product" SelectMethod="GetProduct"
                    RenderOuterTable="false">
                    <ItemTemplate>
                        <div class="col-lg-6">
                            <div class="product__details__pic">
                                <div class="product__details__pic__left product__thumb nice-scroll">
                                    <a class="pt active" href="#product-1">
                                        <img src="img/product/details/<%#:Item.ImagePath1 %>" alt="">
                                    </a>
                                    &nbsp;<a class="pt" href="#product-2"><img src="img/product/details/<%#:Item.ImagePath2 %>" alt="">
                                    </a>
                                    &nbsp;<a class="pt" href="#product-3"><img src="img/product/details/<%#:Item.ImagePath3 %>" alt="">
                                    </a>
                                    &nbsp;<a class="pt" href="#product-4"><img src="img/product/details/<%#:Item.ImagePath4 %>" alt="">
                                    </a>
                                    &nbsp;
                                </div>
                                <div class="product__details__slider__content">
                                    <div class="product__details__pic__slider owl-carousel">
                                        <img data-hash="product-1" class="product__big__img" src="img/product/details/<%#:Item.ImagePath1 %>" alt="">
                                        <img data-hash="product-2" class="product__big__img" src="img/product/details/<%#:Item.ImagePath2 %>" alt="">
                                        <img data-hash="product-3" class="product__big__img" src="img/product/details/<%#:Item.ImagePath3 %>" alt="">
                                        <img data-hash="product-4" class="product__big__img" src="img/product/details/<%#:Item.ImagePath4 %>" alt="">
                                    </div>
                                </div>
                            </div>
                        </div>


                        <div class="col-lg-6">
                            <div class="product__details__text">
                                <h3><%#:Item.ProductName%> <span>Brand: <%#:Item.Brand %></span></h3>
                                <div class="product__details__price">
                                    $ <%#:Item.UnitPrice%><!--$ 75.0 <span>$ 83.0</span>-->
                                   <%-- <asp:Label ID="Price" runat="server" class="hidden">$ <%#:Item.UnitPrice%></asp:Label>
                                    <asp:Label ID="Discount" runat="server" class="hidden"> <%#:Item.Discount%> </asp:Label>
                                --%></div>

                                <p style="text-align: center">
                                    We Have all the best
                                    <br />
                                    Provide only the best and Nothing but the best
                                </p>

                                <div class="product__details__button">
                                    <div class="quantity">
                                        <span>Quantity:</span>
                                        <div class="pro-qty">
                                            <asp:TextBox ID="quantity" runat="server" type="text" value="1"></asp:TextBox>
                                        </div>
                                    </div>
                                    <asp:Button ID="Button1" runat="server" Text="Availability" class="cart-btn" Style="background-color: green;" OnClick="Button1_Click" />
                                    <ul>
                                        <li><a href="#"><span class="fa fa-heart-o"></span></a></li>
                                    </ul>
                                    <br /><br /><br />
                                    <div>
                                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                                        <asp:Image ID="avail" runat="server" Style="visibility: hidden" />
                                    </div>
                                    <br />
                                    <div class="cart">
                                        <a href="AddToCart.aspx?productID=<%#:Item.ProductID %>" class="cart-btn" style="padding: 9px 150px 9px; width: 100%; text-align: center;"><span class="fa fa-shopping-bag"></span>     Add to cart</a>
                                    </div>
                                </div>
                                <div class="product__details__widget">
                                    <ul>
                                        <li>
                                            <span>Promotions:</span>
                                            <p>Free shipping</p>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-12">
                            <div class="product__details__tab">
                                <div class="nav nav-tabs" role="tablist">
                                    <div class="nav-item">
                                        <asp:Label ID="description" runat="server" class="nav-link active">Description</asp:Label>
                                    </div>
                                </div>
                                <div class="tab-content">
                                    <div class="tab-pane active">
                                        <h6>Description</h6>
                                        <p><%#:Item.Description%></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:FormView>
            </div>


            <!-- to add
                        <li>
                            <span>Available color:</span>
                            <div class="color__checkbox">
                                <label for="red">
                                    <input type="radio" name="color__radio" id="red" checked>
                                    <span class="checkmark"></span>
                                </label>
                                <label for="black">
                                    <input type="radio" name="color__radio" id="black">
                                    <span class="checkmark black-bg"></span>
                                </label>
                                <label for="grey">
                                    <input type="radio" name="color__radio" id="grey">
                                    <span class="checkmark grey-bg"></span>
                                </label>
                            </div>
                        </li>
                        <li>
                            <span>Available size:</span>
                            <div class="size__btn">
                                <label for="xs-btn" class="active">
                                    <input type="radio" id="xs-btn">
                                    xs
                                </label>
                                <label for="s-btn">
                                    <input type="radio" id="s-btn">
                                    s
                                </label>
                                <label for="m-btn">
                                    <input type="radio" id="m-btn">
                                    m
                                </label>
                                <label for="l-btn">
                                    <input type="radio" id="l-btn">
                                    l
                                </label>
                            </div>
                        </li>
            -->

            <div class="row">
                <div class="col-lg-12 text-center">
                    <div class="related__title">
                        <h5>FEATURED PRODUCTS</h5>
                    </div>
                </div>
                <asp:Repeater ID="Featured" runat="server">
                    <ItemTemplate>
                        <div class="col-lg-3 col-md-4 col-sm-6 mix <%# Eval("CategoryID") %>">
                            <div class="product__item">
                                <div class="product__item__pic set-bg" data-setbg="img/product/<%# Eval("ImagePath1") %>">
                                    <!--
                                        <div class="label new">New</div>
                                        <div class="label stockout">out of stock</div>
                                        <div class="label">Sale</div>
                                        <div class="product__price">$ 49.0 <span>$ 59.0</span></div> discount
                                        -->
                                    <ul class="product__hover">
                                        <li><a href="img/product/<%# Eval("ImagePath1") %>" class="image-popup"><span class="fa fa-expand"></span></a></li>
                                        <li><a href="#"><span class="fa fa-heart-o"></span></a></li>
                                        <li><a href="#"><span class="fa fa-shopping-bag"></span></a></li>
                                    </ul>
                                </div>
                                <div class="product__item__text">
                                    <h6><a href="ProductDetails.aspx?productID=<%# Eval("ProductID") %>"><%# Eval("ProductName") %></a></h6>
                                    <div class="rating">
                                        <i class="fa fa-star"></i>
                                        <i class="fa fa-star"></i>
                                        <i class="fa fa-star"></i>
                                        <i class="fa fa-star"></i>
                                    </div>
                                    <asp:Label ID="price" class="product__price" runat="server">$ <%# Eval("UnitPrice") %></asp:Label>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </section>
    <!-- Product Details Section End -->

</asp:Content>
