<%@ Page Title="" MaintainScrollPositionOnPostback="true" Language="C#" MasterPageFile="~/HeaderFooter.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Trimetric.LifePartner.Web.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section runat="server" id="profilesection" class="ProfileSection">
        <h1>Profile</h1>


        <div runat="server" class="row">
            <div class="column">
                <div>
                    <label for="name">Name</label>

                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Name"
                        ControlToValidate="txtName" ForeColor="Yellow"></asp:RequiredFieldValidator>
                </div>

             
                <div>
                    <label for="sex">Sex</label>
                    <asp:DropDownList ID="ddlSex" runat="server">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>

                </div>

                <br />
                <div>
                    <label for="age">Age</label>
                    <asp:DropDownList ID="ddlAge" runat="server">
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>
                        <asp:ListItem>26</asp:ListItem>
                        <asp:ListItem>27</asp:ListItem>
                        <asp:ListItem>28</asp:ListItem>
                        <asp:ListItem>29</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                        <asp:ListItem>31</asp:ListItem>
                        <asp:ListItem>32</asp:ListItem>
                        <asp:ListItem>33</asp:ListItem>
                        <asp:ListItem>34</asp:ListItem>
                        <asp:ListItem>35</asp:ListItem>
                        <asp:ListItem>36</asp:ListItem>
                        <asp:ListItem>37</asp:ListItem>
                        <asp:ListItem>38</asp:ListItem>
                        <asp:ListItem>39</asp:ListItem>
                        <asp:ListItem>40</asp:ListItem>
                        <asp:ListItem>41</asp:ListItem>
                        <asp:ListItem>42</asp:ListItem>
                        <asp:ListItem>43</asp:ListItem>
                        <asp:ListItem>44</asp:ListItem>
                        <asp:ListItem>45</asp:ListItem>
                    </asp:DropDownList>

                </div>
                <br />
                <div>
                    <label for="address">Address</label>
                    <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Address"
                        ControlToValidate="txtAddress" ForeColor="Yellow"></asp:RequiredFieldValidator>
                </div>
              
                <div>
                    <label for="ddlDistrict">District</label>
                    <asp:DropDownList ID="ddlDistrict" runat="server">
                        <asp:ListItem>kolhapur</asp:ListItem>
                        <asp:ListItem>sangali</asp:ListItem>
                    </asp:DropDownList>
                </div>


            </div>

            <div class="column">
                <div>
                    <label for="ddlReligion">Religion</label>
                    <asp:DropDownList ID="ddlReligion" runat="server">
                        <asp:ListItem>Hindu</asp:ListItem>
                        <asp:ListItem>Buddh</asp:ListItem>
                        <asp:ListItem>Jain</asp:ListItem>
                        <asp:ListItem>Sikh</asp:ListItem>
                        <asp:ListItem>Christian</asp:ListItem>
                        <asp:ListItem>Islam</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <br />
                <div>
                    <label for="ddlCaste">Caste</label>
                    <asp:DropDownList ID="ddlCaste" runat="server">
                        <asp:ListItem>a</asp:ListItem>
                        <asp:ListItem>a</asp:ListItem>
                        <asp:ListItem>a</asp:ListItem>
                        <asp:ListItem>a</asp:ListItem>
                        <asp:ListItem>a</asp:ListItem>
                    </asp:DropDownList>

                </div>
                <br />

                <div>
                    <label for="phone">Phone Number</label>
                    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Phone Number"
                        ControlToValidate="txtPhone" ForeColor="Yellow"></asp:RequiredFieldValidator>
                </div>
                
                <div>
                    <label for="state">State</label>
                    <asp:DropDownList ID="ddlState" runat="server">
                        <asp:ListItem>Andhra Pradesh</asp:ListItem>
                        <asp:ListItem>Arunachal Pradesh</asp:ListItem>
                        <asp:ListItem>Assam</asp:ListItem>
                        <asp:ListItem>Bihar</asp:ListItem>
                        <asp:ListItem>Chhattisgarh</asp:ListItem>
                        <asp:ListItem>Goa</asp:ListItem>
                        <asp:ListItem>Gujarat</asp:ListItem>
                        <asp:ListItem>Haryana</asp:ListItem>
                        <asp:ListItem>Himachal Pradesh</asp:ListItem>
                        <asp:ListItem>Jammu and Kashmir</asp:ListItem>
                        <asp:ListItem>Jharkhand</asp:ListItem>
                        <asp:ListItem>Karnataka</asp:ListItem>
                        <asp:ListItem>Kerala</asp:ListItem>
                        <asp:ListItem>Madhya Pradesh</asp:ListItem>
                        <asp:ListItem>Maharashtra</asp:ListItem>
                        <asp:ListItem>Manipur</asp:ListItem>
                        <asp:ListItem>Meghalaya</asp:ListItem>
                        <asp:ListItem>Mizoram</asp:ListItem>
                        <asp:ListItem>Nagaland</asp:ListItem>
                        <asp:ListItem>Orissa</asp:ListItem>
                        <asp:ListItem>Punjab</asp:ListItem>
                        <asp:ListItem>Rajasthan</asp:ListItem>
                        <asp:ListItem>Sikkim</asp:ListItem>
                        <asp:ListItem>Tamil Nadu</asp:ListItem>
                        <asp:ListItem>Tripura</asp:ListItem>
                        <asp:ListItem>Andaman and Nicobar Islands</asp:ListItem>
                        <asp:ListItem>Chandigarh</asp:ListItem>
                        <asp:ListItem>Dadra and Nagar Haveli</asp:ListItem>
                        <asp:ListItem>Daman and Diu</asp:ListItem>
                        <asp:ListItem>Delhi</asp:ListItem>
                        <asp:ListItem>Lakshadweep</asp:ListItem>
                        <asp:ListItem>Pondicherry</asp:ListItem>

                    </asp:DropDownList>



                </div>
                <br />
                <div>
                    <label>PostalCode</label>
                    <asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter PostalCode"
                        ControlToValidate="txtPostalCode" ForeColor="Yellow"></asp:RequiredFieldValidator>
                </div>
                <br />
                <div></div>
                <div>
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" Action="Insert" ProfileId="-1" />

                </div>

            </div>

        </div>
    </section>
   


</asp:Content>
