<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadFuncionario.aspx.cs" Inherits="view_Cadastro_CadFuncionario" %>

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

                    <h1>Cadastro de Funcionário</h1>

                    <form class="cadastro" onsubmit="return false">

                             <div class="col-2">
                                 <label>
                                     Nome
                                <input placeholder="Digite se nome" id="txtNomeFuncionario" name="nome" tabindex="1"/>
                                  </label>
                            </div>

                        <div class="col-2">
                                 <label>
                                     Logradouro
                                <input placeholder="Digite seu endereço" id="txtLogradouroFuncionario" name="logradouro" tabindex="2"/>
                                  </label>
                            </div>

                        <div class="col-2">
                                 <label>
                                     Numero
                                <input placeholder="Digite seu numero" id="txtNumeroFuncionario" name="numero" tabindex="3"/>
                                  </label>
                            </div>

                        <div class="col-3">
                                 <label>
                                     Bairro
                                <input placeholder="Digite seu bairro" id="txtBairroFuncionario" name="bairro" tabindex="4"/>
                                  </label>
                            </div>

                        <div class="col-3">
                                 <label>
                                     Cep
                                <input placeholder="Digite seu cep" id="txtCepFuncionario" name="cep" tabindex="5"/>
                                  </label>
                            </div>

                        <div class="col-3">
                                 <label>
                                     Cidade
                                <input placeholder="Digite sua cidade" id="txtCidadeFuncionario" name="cidade" tabindex="6"/>
                                  </label>
                            </div>

                        <div class="col-4">
                                 <label>
                                     Uf
                                <input placeholder="Digite seu uf" id="txtUfFuncionario" name="Uf" tabindex="7"/>
                                  </label>
                            </div>

                        <div class="col-4">
                                 <label>
                                     Email
                                <input placeholder="Digite seu email" id="txtEmailFuncionario" name="Email" tabindex="8"/>
                                  </label>
                            </div>

                        <div class="col-4">
                                 <label>
                                     Celular
                                <input placeholder="Digite seu celular" id="txtCelularFuncionario" name="Celular" tabindex="9"/>
                                  </label>
                            </div>

                        <div class="col-5">
                                 <label>
                                     Telefone
                                <input placeholder="Digite seu telefone" id="txtTelefoneFuncionario" name="telefone" tabindex="10"/>
                                  </label>
                            </div>

                        <div class="col-5">
                                 <label>
                                     Empresa
                                <input placeholder="Digite sua empresa" id="txtEmpresaFuncionario" name="empresa" tabindex="11"/>
                                  </label>
                            </div>

                        <div class="col-6">
                                 <label>
                                     Status
                                <input placeholder="Digite o Status" id="txtStatusFuncionario" name="ststusfuncionario" tabindex="12"/>
                                  </label>
                            </div>

                        <div class="col-6">
                                 <label>
                                     Tipo Funcionario
                                <input placeholder="Digite o tipo funcionario" id="txtTipoFuncionario" name="tipofuncionario" tabindex="13"/>
                                  </label>
                            </div>

                        <div class="col-6">
                                 <label>
                                     Cargo
                                <input placeholder="Digite o cargo" id="txtCargo" name="Cargo" tabindex="14"/>
                                  </label>
                            </div>

                        <div class="col-7">
                                 <label>
                                     Salario
                                <input placeholder="Digite o salário" id="tstSalario" name="salario" tabindex="15"/>
                                  </label>
                            </div>

                        <div class="col-7">
                                 <label>
                                     Descrição
                                <input placeholder="Digite a descrição" id="txtDescricao" name="descricao" tabindex="16"/>
                                  </label>
                            </div>

                       </form>
                </div>

                <div class="col-submit">
                     <button class="submitbtn">Cadastrar</button>
                </div>
      


</body>
</html>
