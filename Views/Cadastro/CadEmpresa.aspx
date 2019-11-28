<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadEmpresa.aspx.cs" Inherits="view_Cadastro_CadEmpresa" %>

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
<body>
  <div class="wrapper">

                    <h1>Cadastro de Empresa</h1>

                    <form class="cadastro" onsubmit="return false">

                             <div class="col-2">
                                 <label>
                                     Empresa
                                <input placeholder="Digite o nome" id="txtNomeEmpresa" name="nome" tabindex="1"/>
                                  </label>
                            </div>

                        <div class="col-2">
                                 <label>
                                     Inscrição Municipal
                                <input placeholder="Digite a inscrição municipal" id="txtInscMunicipal" name="inscricaomunicipal" tabindex="2"/>
                                  </label>
                            </div>

                        <div class="col-2">
                                 <label>
                                     Inscrição Estadual
                                <input placeholder="Digite a inscrição estadual" id="txtInscEstadual" name="inscricaoestadual" tabindex="3"/>
                                  </label>
                            </div>

                        <div class="col-2">
                                 <label>
                                     Cnpj
                                <input placeholder="Digite o cnpj" id="txtCnpj" name="cnpj" tabindex="4"/>
                                  </label>
                            </div>

                        <div class="col-3">
                                 <label>
                                     Cep
                                <input placeholder="Digite o cep" id="txtCepEmpresa" name="cepempresa" tabindex="5"/>
                                  </label>
                            </div>

                        <div class="col-3">
                                 <label>
                                     Cidade
                                <input placeholder="Digite a cidade" id="txtCidadeEmpresa" name="cidadeempresa" tabindex="6"/>
                                  </label>
                            </div>

                        <div class="col-3">
                                 <label>
                                     Uf
                                <input placeholder="Digite o uf" id="txtUfEmpresa" name="UfEmpresa" tabindex="7"/>
                                  </label>
                            </div>

                        <div class="col-4">
                                 <label>
                                     Email
                                <input placeholder="Digite o email" id="txtEmailEmpresa" name="emailempresa" tabindex="8"/>
                                  </label>
                            </div>

                        <div class="col-4">
                                 <label>
                                     Celular
                                <input placeholder="Digite o celular" id="txtCelularEmpresa" name="celularempresa" tabindex="9"/>
                                  </label>
                            </div>

                        <div class="col-5">
                                 <label>
                                     Telefone
                                <input placeholder="Digite o telefone" id="txtTelefoneEmpresa" name="telefoneempresa" tabindex="10"/>
                                  </label>
                            </div>

                        <div class="col-5">
                                 <label>
                                     Status Empresa
                                <input placeholder="Digite o empresa" id="txtStatusEmpresa" name="statusempresa" tabindex="11"/>
                                  </label>
                            </div>
                       </form>
                </div>


      
                 <div class="col-submit">
                     <button class="submitbtn">Cadastrar</button>
                </div>
      

</body>
</html>
