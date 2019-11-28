<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadLocacao.aspx.cs" Inherits="view_Cadastro_CadLocacao" %>

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

                    <h1>Cadastro de Locação</h1>

                    <form class="cadastro" onsubmit="return false">

                             <div class="col-2">
                                 <label>
                                     Código
                                <input placeholder="Digite se nome" id="txtNome" name="nome" tabindex="1"/>
                                  </label>
                            </div>

                        <div class="col-2">
                                 <label>
                                     Data de Locação
                                <input placeholder="Informe a data da locação" id="txtDataLocacao" name="datalocacao" tabindex="2"/>
                                  </label>
                            </div>

                        <div class="col-2">
                                 <label>
                                     Até
                                <input placeholder="Informe a data final da locação" id="txtAteLocacao" name="atelocacao" tabindex="3"/>
                                  </label>
                            </div>

                        <div class="col-3">
                                 <label>
                                     Valor
                                <input placeholder="Informe o valor da locação" id="txtValorLocacao" name="valorlocacao" tabindex="4"/>
                                  </label>
                            </div>

                        <div class="col-3">
                                 <label>
                                     Cliente
                                <input placeholder="Selecione o cliente" id="txtClienteLocacao" name="clienyelocacao" tabindex="5"/>
                                  </label>
                            </div>

                        <div class="col-3">
                                 <label>
                                     Veiculo
                                <input placeholder="Informe o veículo" id="txtVeiculoLocacao" name="veiculolocacao" tabindex="6"/>
                                  </label>
                            </div>

                        <div class="col-4">
                                 <label>
                                     Seguro
                                <input placeholder="Informe o seguro" id="txtseguroLocacao" name="segurolocacao" tabindex="7"/>
                                  </label>
                            </div>

                        <div class="col-4">
                                 <label>
                                     Descrição
                                <input placeholder="Informe a descrição do seguro" id="txtDescricaoSeguro" name="descricaoseguro" tabindex="8"/>
                                  </label>
                            </div>
                                              
                       </form>
                </div>

                <div class="col-submit">
                     <button class="submitbtn">Cadastrar</button>
                </div>


</body>
</html>
