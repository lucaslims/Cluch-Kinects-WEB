<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadCliente.aspx.cs" Inherits="view_Cadastro_CadCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>



      <meta charset="utf-8"/>
        <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
        <meta name="viewport" content="width=device-width, initial-scale=1"/>
        <link rel="shortcut icon" href="http://static.tmimgcdn.com/img/favicon.ico"/>
        <link rel="icon" href="http://static.tmimgcdn.com/img/favicon.ico"/>
        <script src="../js/switchery.min.js" type="text/javascript"></script>

         <link href="../../css/StyleCadastro.css" rel="stylesheet" />

         <!-- Bootstrap -->
        <link href="../css/bootstrap.min.css" rel="stylesheet" />
        <link href="../css/switchery.min.css" media="all" type="text/css" rel="stylesheet" />
        <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
        <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
        <!--[if lt IE 9]>
          <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
          <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
        <![endif]-->



</head>
<body class="cadcliente">
    <!--Cadastro Cliente-->

                <div class="wrapper">

                    <h1>Cadastro de Cliente</h1>

                    <form class="cadastro" onsubmit="return false">

                    <div class="col-2">
                        <label>Nome</label>
                        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                        
                        <label>CEP:</label>
                        <asp:TextBox ID="txtCep" runat="server"></asp:TextBox>   
                        
                        <label>Rua</label>
                        <asp:TextBox ID="txtRua" runat="server"></asp:TextBox>   
                        
                        <label>Numero</label>
                        <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>   
                        
                        <label>Complemento</label>
                        <asp:TextBox ID="txtComplmento" runat="server"></asp:TextBox>   
                        
                        <label>Bairro</label>
                        <asp:TextBox ID="txtBairro" runat="server"></asp:TextBox>   
                        
                        <label>Cidade</label>
                        <asp:TextBox ID="txtCidade" runat="server"></asp:TextBox>   
                        
                        <label>Estado:</label>
                        <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>

                        <label>E-Mail:</label>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>   
                        
                        <label>Celular:</label>
                        <asp:TextBox ID="txtCelular" runat="server"></asp:TextBox> 
                        
                        <label>Telefone:</label>
                        <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox> 
                        
                        <label>Nome</label>
                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox> 
                        
                        <label>Nome</label>
                        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>                                   
                    </div>

                <div class="col-submit">
                     <button id="btnCadastrar" Onclick="btn_Cadastrar" class="submitbtn">Cadastrar</button>
                </div>
      
                
                <!--Cadastro Cliente-->

</body>
</html>
