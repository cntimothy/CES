﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadStaffInfo.aspx.cs"
    Inherits="CES.UI.Pages.StaffManagement.UploadStaffInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../css/default.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" runat="server" AutoSizePanelID="Panel1" />
    <x:Panel ID="Panel1" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
        Title="Panel" Layout="Fit">
        <Items>
            <x:Panel ID="Panel3" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
                Title="Panel" AutoScroll="true">
                <Items>
                    <x:Toolbar ID="Toolbar1" runat="server" CssClass="mytoolbar">
                        <Items>
                            <x:FileUpload ID="FileUpload_ExcelFile" runat="server" Label="Label" ButtonOnly="true"
                                ButtonText="选择上传文件" AutoPostBack="true" OnFileSelected="FileUpload_ExcelFile_FileSelected">
                            </x:FileUpload>
                            <x:ToolbarSeparator ID="ToolbarSeparator1" runat="server">
                            </x:ToolbarSeparator>
                            <x:Label ID="Label1" runat="server" Label="Label" Text="您选择的文件是:">
                            </x:Label>
                            <x:Label ID="Label_FileName" runat="server" Label="Label" Text="">
                            </x:Label>
                            <x:ToolbarSeparator ID="ToolbarSeparator2" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button_Submit" runat="server" Text="开始上传" OnClick="Button_Submit_Click"
                                Enabled="false">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator3" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button_Delete" runat="server" Text="删除所选" OnClick="Button_Delete_Click">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator4" runat="server">
                            </x:ToolbarSeparator>
                            <x:ToolbarFill ID="ToolbarFill1" runat="server">
                            </x:ToolbarFill>
                            <x:Button ID="Button_DownloadTemplate" runat="server" Text="下载模板" OnClick="Button_DownloadTemplate_Click"
                                EnableAjax="false">
                            </x:Button>
                        </Items>
                    </x:Toolbar>
                    <x:Panel ID="Panel2" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false"
                        Title="">
                        <Items>
                            <x:Grid ID="Grid1" runat="server" Title="Grid" AllowPaging="true" PageSize="20" EnableRowNumber="true"
                                Height="520px" AutoScroll="true" DataKeyNames="ID" EnableCheckBoxSelect="true"
                                CheckBoxSelectOnly="true" OnPageIndexChange="Grid1_PageIndexChange" ClearSelectedRowsAfterPaging="false">
                                <Columns>
                                    <x:BoundField Width="150px" DataField="ID" DataFormatString="{0}" HeaderText="工号"
                                        Hidden="true" />
                                    <x:BoundField Width="200px" DataField="Name" DataFormatString="{0}" HeaderText="姓名"
                                        Hidden="true" />
                                    <x:BoundField Width="50px" DataField="Sex" DataFormatString="{0}" HeaderText="性别"
                                        Hidden="true" />
                                    <x:BoundField Width="200px" DataField="Job" DataFormatString="{0}" HeaderText="职务"
                                        Hidden="true" />
                                    <x:BoundField Width="150px" DataField="Role" DataFormatString="{0}" HeaderText="身份"
                                        Hidden="true" />
                                    <x:BoundField Width="300px" DataField="Tele" DataFormatString="{0}" HeaderText="电话"
                                        Hidden="true" />
                                </Columns>
                            </x:Grid>
                        </Items>
                    </x:Panel>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    <x:HiddenField ID="hfSelectedIDS" runat="server">
    </x:HiddenField>
    <x:Window ID="Window_Modify" runat="server" BodyPadding="5px" IsModal="true" Popup="false"
        Title="修改" Width="500px" Height="400px" EnableClose="false" Target="Top" EnableResize="true"
        EnableIFrame="true" IFrameUrl="about:blank">
    </x:Window>
    </form>
</body>
</html>
