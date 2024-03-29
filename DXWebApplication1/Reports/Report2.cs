﻿<?xml version="1.0" encoding="utf-8"?>
<XtraReportsLayoutSerializer SerializerVersion="21.2.7.0" Ref="1" ControlType="TestReport, DXWebApplication1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null" Name="TestReport" DisplayName="Report2" PageWidth="850" PageHeight="1100" Version="21.2" EventsInfo="tableCell4,BeforePrint,tableCell4_BeforePrint" DataMember="Categories" DataSource="#Ref-0">
  <Extensions>
    <Item1 Ref="2" Key="DataSerializationExtension" Value="DevExpress.XtraReports.Web.ReportDesigner.DefaultDataSerializer" />
  </Extensions>
  <Bands>
    <Item1 Ref="3" ControlType="TopMarginBand" Name="TopMargin" />
    <Item2 Ref="4" ControlType="ReportHeaderBand" Name="ReportHeader" HeightF="113.125">
      <Controls>
        <Item1 Ref="5" ControlType="XRLabel" Name="label9" Multiline="true" SizeF="133.333,23" LocationFloat="446.625,70.257" Padding="2,2,0,0,100" />
        <Item2 Ref="6" ControlType="XRLabel" Name="label8" Multiline="true" SizeF="133.333,23" LocationFloat="446.625,47.257" Padding="2,2,0,0,100" />
        <Item3 Ref="7" ControlType="XRLabel" Name="label7" Multiline="true" SizeF="133.333,23" LocationFloat="121.625,70.257" Padding="2,2,0,0,100" />
        <Item4 Ref="8" ControlType="XRLabel" Name="label6" Multiline="true" SizeF="133.333,23" LocationFloat="121.625,47.257" Padding="2,2,0,0,100" />
        <Item5 Ref="9" ControlType="XRLabel" Name="label5" Multiline="true" Text="Date : " SizeF="115.625,23" LocationFloat="331,70.257" Padding="2,2,0,0,100" />
        <Item6 Ref="10" ControlType="XRLabel" Name="label4" Multiline="true" Text="Bill No. :" SizeF="115.625,23" LocationFloat="331,47.257" Padding="2,2,0,0,100" />
        <Item7 Ref="11" ControlType="XRLabel" Name="label3" Multiline="true" Text="Agent Code : " SizeF="115.625,23" LocationFloat="6,70.257" Padding="2,2,0,0,100" />
        <Item8 Ref="12" ControlType="XRLabel" Name="label2" Multiline="true" Text="Name of the Agent : " SizeF="115.625,23" LocationFloat="6,47.257" Padding="2,2,0,0,100" />
        <Item9 Ref="13" ControlType="XRLabel" Name="label1" Text="AGENT'S COMMISSION BILL" SizeF="638,24.19433" LocationFloat="6,6" StyleName="Title" />
      </Controls>
    </Item2>
    <Item3 Ref="14" ControlType="GroupHeaderBand" Name="GroupHeader1" GroupUnion="WithFirstDetail" HeightF="113.417">
      <Controls>
        <Item1 Ref="15" ControlType="XRTable" Name="table1" SizeF="650,28" LocationFloat="0,0">
          <Rows>
            <Item1 Ref="16" ControlType="XRTableRow" Name="tableRow1" Weight="1">
              <Cells>
                <Item1 Ref="17" ControlType="XRTableCell" Name="tableCell1" Weight="0.34163161057692309" Text="Category ID" TextAlignment="MiddleRight" StyleName="DetailCaption1" Borders="None">
                  <StylePriority Ref="18" UseBorders="false" UseTextAlignment="false" />
                </Item1>
                <Item2 Ref="19" ControlType="XRTableCell" Name="tableCell2" Weight="0.427702871469351" Text="Category Name" StyleName="DetailCaption1" />
                <Item3 Ref="20" ControlType="XRTableCell" Name="tableCell3" Weight="0.23066551795372597" Text="Picture" StyleName="DetailCaption1" />
              </Cells>
            </Item1>
          </Rows>
        </Item1>
      </Controls>
    </Item3>
    <Item4 Ref="21" ControlType="DetailBand" Name="Detail" HeightF="81.25">
      <Controls>
        <Item1 Ref="22" ControlType="XRTable" Name="table2" SizeF="650,25" LocationFloat="0,0" OddStyleName="DetailData3_Odd">
          <Rows>
            <Item1 Ref="23" ControlType="XRTableRow" Name="tableRow2" Weight="11.5">
              <Cells>
                <Item1 Ref="24" ControlType="XRTableCell" Name="tableCell4" Weight="0.34163161057692309" TextAlignment="MiddleRight" StyleName="DetailData1" Borders="None">
                  <Scripts Ref="25" OnBeforePrint="tableCell4_BeforePrint" />
                  <ExpressionBindings>
                    <Item1 Ref="26" EventName="BeforePrint" PropertyName="Text" Expression="[CategoryID]" />
                  </ExpressionBindings>
                  <StylePriority Ref="27" UseBorders="false" UseTextAlignment="false" />
                </Item1>
                <Item2 Ref="28" ControlType="XRTableCell" Name="tableCell5" Weight="0.427702871469351" StyleName="DetailData1">
                  <ExpressionBindings>
                    <Item1 Ref="29" EventName="BeforePrint" PropertyName="Text" Expression="[CategoryName]" />
                  </ExpressionBindings>
                </Item2>
                <Item3 Ref="30" ControlType="XRTableCell" Name="tableCell6" Weight="0.23066551795372597" StyleName="DetailData1">
                  <Controls>
                    <Item1 Ref="31" ControlType="XRPictureBox" Name="pictureBox1" Sizing="ZoomImage" AnchorVertical="Both" AnchorHorizontal="Both" SizeF="147.8493,25" LocationFloat="2.083333,0">
                      <ExpressionBindings>
                        <Item1 Ref="32" EventName="BeforePrint" PropertyName="ImageSource" Expression="[Picture]" />
                      </ExpressionBindings>
                    </Item1>
                  </Controls>
                </Item3>
              </Cells>
            </Item1>
          </Rows>
        </Item1>
      </Controls>
    </Item4>
    <Item5 Ref="33" ControlType="BottomMarginBand" Name="BottomMargin">
      <Controls>
        <Item1 Ref="34" ControlType="XRPageInfo" Name="pageInfo1" PageInfo="DateTime" SizeF="313,23" LocationFloat="6,6" StyleName="PageInfo" />
        <Item2 Ref="35" ControlType="XRPageInfo" Name="pageInfo2" TextFormatString="Page {0} of {1}" TextAlignment="TopRight" SizeF="313,23" LocationFloat="331,6" StyleName="PageInfo" />
      </Controls>
    </Item5>
  </Bands>
  <StyleSheet>
    <Item1 Ref="36" Name="Title" BorderStyle="Inset" Font="Arial, 14.25pt" ForeColor="255,75,75,75" BackColor="Transparent" BorderColor="Black" Sides="None" StringFormat="Near;Near;0;None;Character;Default" BorderWidthSerializable="1" />
    <Item2 Ref="37" Name="DetailCaption1" BorderStyle="Inset" Padding="6,6,0,0,100" Font="Arial, 8.25pt, style=Bold" ForeColor="White" BackColor="255,75,75,75" BorderColor="White" Sides="Left" StringFormat="Near;Center;0;None;Character;Default" TextAlignment="MiddleLeft" BorderWidthSerializable="2" />
    <Item3 Ref="38" Name="DetailData1" BorderStyle="Inset" Padding="6,6,0,0,100" Font="Arial, 8.25pt" ForeColor="Black" BorderColor="Transparent" Sides="Left" StringFormat="Near;Center;0;None;Character;Default" TextAlignment="MiddleLeft" BorderWidthSerializable="2" />
    <Item4 Ref="39" Name="DetailData3_Odd" BorderStyle="Inset" Padding="6,6,0,0,100" Font="Arial, 8.25pt" ForeColor="Black" BackColor="255,231,231,231" BorderColor="Transparent" Sides="None" StringFormat="Near;Center;0;None;Character;Default" TextAlignment="MiddleLeft" BorderWidthSerializable="1" />
    <Item5 Ref="40" Name="PageInfo" BorderStyle="Inset" Padding="2,2,0,0,100" Font="Arial, 8.25pt, style=Bold" ForeColor="255,75,75,75" StringFormat="Near;Near;0;None;Character;Default" />
  </StyleSheet>
  <ComponentStorage>
    <Item1 Ref="0" ObjectType="DevExpress.DataAccess.Sql.SqlDataSource,DevExpress.DataAccess.v21.2" Name="sqlDataSource1" Base64="PFNxbERhdGFTb3VyY2UgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxDb25uZWN0aW9uIE5hbWU9Ik5XaW5kQ29ubmVjdGlvblN0cmluZyIgRnJvbUFwcENvbmZpZz0idHJ1ZSIgLz48UXVlcnkgVHlwZT0iU2VsZWN0UXVlcnkiIE5hbWU9IkNhdGVnb3JpZXMiPjxUYWJsZXM+PFRhYmxlIE5hbWU9IkNhdGVnb3JpZXMiIC8+PC9UYWJsZXM+PENvbHVtbnM+PENvbHVtbiBUYWJsZT0iQ2F0ZWdvcmllcyIgTmFtZT0iQ2F0ZWdvcnlJRCIgLz48Q29sdW1uIFRhYmxlPSJDYXRlZ29yaWVzIiBOYW1lPSJDYXRlZ29yeU5hbWUiIC8+PENvbHVtbiBUYWJsZT0iQ2F0ZWdvcmllcyIgTmFtZT0iRGVzY3JpcHRpb24iIC8+PENvbHVtbiBUYWJsZT0iQ2F0ZWdvcmllcyIgTmFtZT0iUGljdHVyZSIgLz48L0NvbHVtbnM+PC9RdWVyeT48UmVzdWx0U2NoZW1hPjxEYXRhU2V0IE5hbWU9InNxbERhdGFTb3VyY2UxIj48VmlldyBOYW1lPSJDYXRlZ29yaWVzIj48RmllbGQgTmFtZT0iQ2F0ZWdvcnlJRCIgVHlwZT0iSW50MzIiIC8+PEZpZWxkIE5hbWU9IkNhdGVnb3J5TmFtZSIgVHlwZT0iU3RyaW5nIiAvPjxGaWVsZCBOYW1lPSJEZXNjcmlwdGlvbiIgVHlwZT0iU3RyaW5nIiAvPjxGaWVsZCBOYW1lPSJQaWN0dXJlIiBUeXBlPSJCeXRlQXJyYXkiIC8+PC9WaWV3PjwvRGF0YVNldD48L1Jlc3VsdFNjaGVtYT48Q29ubmVjdGlvbk9wdGlvbnMgQ2xvc2VDb25uZWN0aW9uPSJ0cnVlIiAvPjwvU3FsRGF0YVNvdXJjZT4=" />
  </ComponentStorage>
</XtraReportsLayoutSerializer>