<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadMotorista.aspx.cs" Inherits="view_Cadastro_CadMotorista" %>

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

                    <h1>Cadastro de Motorista</h1>

                    <form class="cadastro" onsubmit="return false">

                             <div class="col-2">
                                 <label>
                                     Nome
                                <input placeholder="Digite se nome" id="txtNomeMotorista" name="nome" tabindex="1"/>
                                  </label>
                            </div>

                        <div class="col-2">
                                 <label>
                                     Logradouro
                                <input placeholder="Digite seu endereço" id="txtLogradouroMotorista" name="logradouro" tabindex="2"/>
                                  </label>
                            </div>

                        <div class="col-2">
                                 <label>
                                     Numero
                                <input placeholder="Digite seu numero" id="txtNumeroMotorista" name="numero" tabindex="3"/>
                                  </label>
                            </div>

                        <div class="col-3">
                                 <label>
                                     Bairro
                                <input placeholder="Digite seu bairro" id="txtBairroMotorista" name="bairro" tabindex="4"/>
                                  </label>
                            </div>

                        <div class="col-3">
                                 <label>
                                     Cep
                                <input placeholder="Digite seu cep" id="txtCepMotorista" name="cep" tabindex="5"/>
                                  </label>
                            </div>

                        <div class="col-3">
                                 <label>
                                     Cidade
                                <input placeholder="Digite sua cidade" id="txtCidadeMotorista" name="cidade" tabindex="6"/>
                                  </label>
                            </div>

                        <div class="col-4">
                                 <label>
                                     Uf
                                <input placeholder="Digite seu uf" id="txtUfMotorista" name="Uf" tabindex="7"/>
                                  </label>
                            </div>

                        <div class="col-4">
                                 <label>
                                     Email
                                <input placeholder="Digite seu email" id="txtEmailMotorista" name="Email" tabindex="8"/>
                                  </label>
                            </div>

                        <div class="col-4">
                                 <label>
                                     Celular
                                <input placeholder="Digite seu celular" id="txtCelularMotorista" name="Celular" tabindex="9"/>
                                  </label>
                            </div>

                        <div class="col-5">
                                 <label>
                                     Telefone
                                <input placeholder="Digite seu telefone" id="txtTelefoneMotorista" name="telefone" tabindex="10"/>
                                  </label>
                            </div>

                        <div class="col-5">
                                 <label>
                                     Empresa
                                <input placeholder="Digite sua empresa" id="txtEmpresaMotorista" name="empresa" tabindex="11"/>
                                  </label>
                            </div>

                        <div class="col-6">
                                 <label>
                                     Status
                                <input placeholder="Digite o Status" id="txtStatusMotorista" name="ststusmotorista" tabindex="12"/>
                                  </label>
                            </div>

                        <div class="col-6">
                                 <label>
                                     Código Motorista
                                <input placeholder="Digite o tipo funcionario" id="txtTipoFuncionario" name="idmotorista" tabindex="13"/>
                                  </label>
                            </div>

                        <div class="col-6">
                                 <label>
                                     Numero Cnh
                                <input placeholder="Digite o numero da cnh" id="txtCnh" name="cnhmotorista" tabindex="14"/>
                                  </label>
                            </div>

                        <div class="col-7">
                                 <label>
                                     Data de Validade
                                <input placeholder="Digite a data de validade" id="txtDataValidade" name="datavalidademotorista" tabindex="15"/>
                                  </label>
                            </div>

                        <div class="col-7">
                                 <label>
                                     Categoria
                                <input placeholder="Digite a categoria da cnh" id="txtCategoria" name="categoriacnhmotorista" tabindex="16"/>
                                  </label>
                            </div>

                       </form>
                </div>

                <div class="col-submit">
                     <button class="submitbtn">Cadastrar</button>
                </div>
</body>
</html>
