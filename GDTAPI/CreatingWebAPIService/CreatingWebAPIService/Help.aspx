<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Help.aspx.cs" Inherits="DevetchAPI.Help" %>

<html lang="en">
<head>
    <meta http-equiv="content-type" content="text/html; charset=UTF-8">
    <meta charset="utf-8">
    <title>GDTAPI</title>
    <link rel="icon" type="image/png" href="Img/favicon.ico" />
    <meta name="generator" content="Bootply" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <!--[if lt IE 9]>
			<script src="//html5shim.googlecode.com/svn/trunk/html5.js"></script>
		<![endif]-->
    <link href="css/styles.css" rel="stylesheet">
    <style>
        .table {
            border-bottom: 1px solid #ddd;
            border-top: none;
            border-left: 1px solid #ddd;
            border-right: 1px solid #ddd;
            font-size: 10pt;
        }

        .imgg {
            width:75%;
            margin-top:-5%;
        }
    </style>
</head>
<body>
    <nav class="navbar navbar-fixed-top header">
        <div class="col-md-12">
            <div class="navbar-header">

                <a href="#" class="navbar-brand" style=""><asp:Image ID="Image1" runat="server"  ImageUrl="~/Img/devtechlogo.png"  CssClass="imgg" /></a>
                

            </div>

        </div>
    </nav>

    <form runat="server">
        <!--main-->
        <div class="container" id="main" style="margin-top: -2%;">
            <div class="row">
                <div class="col-md-12 col-sm-6">
                    <div class="panel panel-default" id="divIndex">
                        <div class="panel-heading">
                            <a href="#" class="pull-right"></a>
                            <h4>API Functions</h4>
                        </div>
                        <div class="panel-body">
                            <div class="list-group">
                               
                                 <a href="#AllNodesOnOffDim" role="button" data-toggle="modal" class="list-group-item"><b>1. ON/OFF/DIM (All Nodes) </b>: Protocol is used for all nodes on/off.dim.</a>
                                  <a href="#SingleNodeOnOffDim" role="button" data-toggle="modal" class="list-group-item"><b>2. ON/OFF/DIM (Single Node) </b>: Protocol is used for single nodes on/off.dim.</a>
                                  <a href="#EnergyDataParameters" role="button" data-toggle="modal" class="list-group-item"><b>3. Energy Data Parameters (Single Node) </b>: Protocol is used to get single node energy parameter data.</a>
                                
                            </div>
                        </div>
                        <!--Group On/Off-->
                        <div id="GroupOnOff" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">

                            <div class="panel-body">

                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>Group On/Off </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: GroupOnOff</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to all nodes On/Off.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                       <label id="lblGroupOnOff" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>FlagOnOff</td>
                                                    <td>String</td>
                                                    <td>For On - 1 / Off - 0</td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!--Group On/Off-->

                        <!--R Phase On/Off-->
                        <div id="RPhaseOnOff" class="modal fade" tabindex="-2" role="dialog" aria-hidden="true">
                            <div class="panel-body">
                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>R Phase On/Off </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: RPhaseOnOff</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to all R Phase nodes On/Off.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="lblRPhaseOnOff" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>FlagOnOff</td>
                                                    <td>String</td>
                                                    <td>For On - 1 / Off - 0</td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!---R Phase On/Off-->

                        <!--Y Phase On/Off-->
                        <div id="YPhaseOnOff" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">

                            <div class="panel-body">


                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>Y Phase On/Off </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: YPhaseOnOff</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to all Y Phase nodes On/Off.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="lblYPhaseOnOff" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>FlagOnOff</td>
                                                    <td>String</td>
                                                    <td>For On - 1 / Off - 0</td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!---Y Phase On/Off-->

                        <!--B Phase On/Off-->
                        <div id="BPhaseOnOff" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">


                            <div class="panel-body">


                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>B Phase On/Off </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: BPhaseOnOff</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to all B Phase nodes On/Off.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="lblBPhaseOnOff" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>FlagOnOff</td>
                                                    <td>String</td>
                                                    <td>For On - 1 / Off - 0</td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!---B Phase On/Off-->

                        <!--Get Current Status-->
                        <div id="GetCurrentStatus" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">

                            <div class="panel-body">


                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>Get Current Status </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: GetCurrentStatus</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to get controller current status.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="lblGetCurrentStatus" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!--Get Current Status-->

                         <!--Set RTC-->
                        <div id="SetRTC" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">

                            <div class="panel-body">


                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>Set Real Time Clock (RTC) </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: SetRTC</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to set Real Time Clock (RTC).</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="lblSetRTC" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>
                                                 <tr>
                                                    <td>RTC</td>
                                                    <td>String</td>
                                                    <td>Real Time Clock (Format - dd/mm/yyyy hh:mm:ss)</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!--Set RTC-->

                          <!--All Nodes On/Off/Dim-->
                        <div id="AllNodesOnOffDim" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">

                            <div class="panel-body">


                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>ON/OFF/DIM (All Nodes) </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: AllNodesOnOffDim</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Protocol is used for all nodes on/off.dim.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="lblAllNodesOnOffDim" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>FlagOnOff</td>
                                                    <td>String</td>
                                                    <td>For On - 1 / Off - 0 / Dim - 1</td>
                                                </tr>
                                                 <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Macid</td>
                                                </tr>
                                                <tr>
                                                    <td>DimValue</td>
                                                    <td>String</td>
                                                    <td>Dimming Value (For No Dimming -> -1 & For Dimming -> Range 0 to 100)</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                     <td><b>Response</b></td>
                                                    <td><b>Description</b></td>
                                                   
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                                 <tr>
                                                    <td>" "</td>
                                                    <td>No Communication</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                          <!--All Nodes On/Off/Dim-->

                         <!--Single Node On/Off/Dim-->
                        <div id="SingleNodeOnOffDim" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">

                            <div class="panel-body">


                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>ON/OFF/DIM (Single Node) </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: SingleNodeOnOffDim</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Protocol is used for single node on/off.dim.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="lblSingleNodeOnOffDim" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>FlagOnOff</td>
                                                    <td>String</td>
                                                    <td>For On - 1 / Off - 0 / Dim - 1</td>
                                                </tr>
                                                 <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Macid</td>
                                                </tr>
                                                <tr>
                                                    <td>NodeId</td>
                                                    <td>String</td>
                                                    <td>Device Node Id</td>
                                                </tr>
                                                 <tr>
                                                    <td>DimValue</td>
                                                    <td>String</td>
                                                    <td>Dimming Value (For No Dimming -> -1 & For Dimming -> Range 0 to 100)</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Response</b></td>
                                                    <td><b>Description</b></td>
                                                    
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                                 <tr>
                                                    <td>" "</td>
                                                    <td>No Communication</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                         <!--Single Node On/Off/Dim-->

                         <!--Energy Meter Parameters-->
                        <div id="EnergyDataParameters" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">

                            <div class="panel-body">


                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>Energy Data Parameters (Single Node) </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: SingleNodeGetEnergyData </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Protocol is used to get single node energy parameter data.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="lblSingleNodeGetEnergyData" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                              
                                                 <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Macid</td>
                                                </tr>
                                                <tr>
                                                    <td>NodeId</td>
                                                    <td>String</td>
                                                    <td>Device Node Id</td>
                                                </tr>
                                                

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Response</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>Supply Voltage,Supply Current,Power,Frequency,PowerFactor,Active Energy,Device Burning Hrs,LED Burning Hrs,Relay Status</td>
                                                    <td>Result</td>
                                                    
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                                <tr>
                                                    <td>" "</td>
                                                    <td>No Communication</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                         <!--Energy Meter Parameters-->
                    </div>
                </div>

                <div class="col-md-6 col-sm-6" style="display:none">
                    <div class="panel panel-default" id="divIndex">
                        <div class="panel-heading">
                            <a href="#" class="pull-right"></a>
                            <h4>API Functions - Controller Get Protocol</h4>
                        </div>
                        <div class="panel-body">
                            <div class="list-group">
                              
                                
                                 <a href="#GetCurrentStatus" role="button" data-toggle="modal" class="list-group-item"><b>1. Get Current Status </b>: Use to get controller current status.</a>
                                 
                               
                                
                            </div>
                        </div>
                        <!--Group On/Off-->
                        <div id="GroupOnOff" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">

                            <div class="panel-body">

                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>Group On/Off </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: GroupOnOff</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to all nodes On/Off.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                       <label id="Label1" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>FlagOnOff</td>
                                                    <td>String</td>
                                                    <td>For On - 1 / Off - 0</td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!--Group On/Off-->

                        <!--R Phase On/Off-->
                        <div id="RPhaseOnOff" class="modal fade" tabindex="-2" role="dialog" aria-hidden="true">
                            <div class="panel-body">
                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>R Phase On/Off </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: RPhaseOnOff</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to all R Phase nodes On/Off.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="Label2" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>FlagOnOff</td>
                                                    <td>String</td>
                                                    <td>For On - 1 / Off - 0</td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!---R Phase On/Off-->

                        <!--Y Phase On/Off-->
                        <div id="YPhaseOnOff" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">

                            <div class="panel-body">


                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>Y Phase On/Off </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: YPhaseOnOff</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to all Y Phase nodes On/Off.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="Label3" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>FlagOnOff</td>
                                                    <td>String</td>
                                                    <td>For On - 1 / Off - 0</td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!---Y Phase On/Off-->

                        <!--B Phase On/Off-->
                        <div id="BPhaseOnOff" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">


                            <div class="panel-body">


                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>B Phase On/Off </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: BPhaseOnOff</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to all B Phase nodes On/Off.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="Label4" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>FlagOnOff</td>
                                                    <td>String</td>
                                                    <td>For On - 1 / Off - 0</td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!---B Phase On/Off-->

                        <!--Get Current Status-->
                        <div id="GetCurrentStatus" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">

                            <div class="panel-body">


                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>Get Current Status </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: GetCurrentStatus</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to get controller current status.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="Label5" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!--Get Current Status-->

                         <!--Set RTC-->
                        <div id="SetRTC" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">

                            <div class="panel-body">


                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>Set Real Time Clock (RTC) </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: SetRTC</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to set Real Time Clock (RTC).</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="Label6" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>
                                                 <tr>
                                                    <td>RTC</td>
                                                    <td>String</td>
                                                    <td>Real Time Clock (Format - dd/mm/yyyy hh:mm:ss)</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!--Set RTC-->
                    </div>
                </div>

                <div class="col-md-6 col-sm-6" style="display:none">
                    <div class="panel panel-default" id="divIndex">
                        <div class="panel-heading">
                            <a href="#" class="pull-right"></a>
                            <h4>API Functions - Controller Phase Protocol</h4>
                        </div>
                        <div class="panel-body">
                            <div class="list-group">
                              
                               
                                <a href="#GroupOnOff" role="button" data-toggle="modal" class="list-group-item"><b>1. Group On/Off</b> : Use to all nodes On/Off. </a>
                                <a href="#RPhaseOnOff" role="button" data-toggle="modal" class="list-group-item"><b>2. R Phase On/Off</b> : Use to all R Phase nodes On/Off.</a>
                                <a href="#YPhaseOnOff" role="button" data-toggle="modal" class="list-group-item"><b>3. Y Phase On/Off</b> : Use to all Y Phase nodes On/Off.</a>
                                <a href="#BPhaseOnOff" role="button" data-toggle="modal" class="list-group-item"><b>4. B Phase On Off</b> : Use to all B Phase nodes On/Off.</a>
                               
                                
                            </div>
                        </div>
                        <!--Group On/Off-->
                        <div id="GroupOnOff" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">

                            <div class="panel-body">

                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>Group On/Off </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: GroupOnOff</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to all nodes On/Off.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                       <label id="Label7" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>FlagOnOff</td>
                                                    <td>String</td>
                                                    <td>For On - 1 / Off - 0</td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!--Group On/Off-->

                        <!--R Phase On/Off-->
                        <div id="RPhaseOnOff" class="modal fade" tabindex="-2" role="dialog" aria-hidden="true">
                            <div class="panel-body">
                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>R Phase On/Off </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: RPhaseOnOff</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to all R Phase nodes On/Off.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="Label8" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>FlagOnOff</td>
                                                    <td>String</td>
                                                    <td>For On - 1 / Off - 0</td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!---R Phase On/Off-->

                        <!--Y Phase On/Off-->
                        <div id="YPhaseOnOff" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">

                            <div class="panel-body">


                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>Y Phase On/Off </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: YPhaseOnOff</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to all Y Phase nodes On/Off.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="Label9" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>FlagOnOff</td>
                                                    <td>String</td>
                                                    <td>For On - 1 / Off - 0</td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!---Y Phase On/Off-->

                        <!--B Phase On/Off-->
                        <div id="BPhaseOnOff" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">


                            <div class="panel-body">


                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>B Phase On/Off </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: BPhaseOnOff</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to all B Phase nodes On/Off.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="Label10" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>FlagOnOff</td>
                                                    <td>String</td>
                                                    <td>For On - 1 / Off - 0</td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!---B Phase On/Off-->

                        <!--Get Current Status-->
                        <div id="GetCurrentStatus" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">

                            <div class="panel-body">


                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>Get Current Status </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: GetCurrentStatus</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to get controller current status.</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="Label11" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!--Get Current Status-->

                         <!--Set RTC-->
                        <div id="SetRTC" class="modal fade" tabindex="-1" role="dialog" aria-hidden="true">

                            <div class="panel-body">


                                <div class="list-group">
                                    <a class="list-group-item" style="border: none !important;">
                                        <h4><b>Set Real Time Clock (RTC) </b></h4>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Function Name </b>: SetRTC</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Description </b>: Use to set Real Time Clock (RTC).</a>
                                    <a class="list-group-item" style="border: none !important;"><b>Request (POST) </b>:
                                        <label id="Label12" style="font-weight: 100" runat="server"></label>
                                    </a>

                                    <a class="list-group-item" style="border: none !important;"><b>Parameters </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Data Params</b></td>
                                                    <td><b>Values</b></td>
                                                    <td><b>Description</b></td>
                                                </tr>
                                                <tr>
                                                    <td>MacId</td>
                                                    <td>String</td>
                                                    <td>Controller Mac Id</td>
                                                </tr>
                                                 <tr>
                                                    <td>RTC</td>
                                                    <td>String</td>
                                                    <td>Real Time Clock (Format - dd/mm/yyyy hh:mm:ss)</td>
                                                </tr>

                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;"><b>Response </b>: </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <div class="table-responsive">
                                            <table class="table">
                                                <tr>
                                                    <td><b>Status</b></td>
                                                    <td><b>Response</b></td>
                                                </tr>
                                                <tr>
                                                    <td>1</td>
                                                    <td>Success</td>
                                                </tr>
                                                <tr>
                                                    <td>0</td>
                                                    <td>Unsuccess/No Response</td>
                                                </tr>
                                                <tr>
                                                    <td>-1</td>
                                                    <td>Error</td>
                                                </tr>
                                            </table>
                                        </div>
                                    </a>
                                    <a class="list-group-item" style="border: none !important;">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal" aria-hidden="true">Close</button></a>
                                </div>
                            </div>
                        </div>
                        <!--Set RTC-->
                    </div>
                </div>
                <!--/row-->
            </div>
        </div>
        <!--/main-->
    </form>
    <!-- script references -->
    <script src="//ajax.googleapis.com/ajax/libs/jquery/2.0.2/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/scripts.js"></script>
</body>
</html>
