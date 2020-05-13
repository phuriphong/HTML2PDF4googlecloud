using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SCGEpur.Models
{

    public class AgmList_Result
    {
        public long AgmId { get; set; }
        public string AgmNo { get; set; }
        public string Description { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCode { get; set; }
        public DateTime DocDate { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StatusCode { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public int Status { get; set; }
        public string Statusbgcolor { get; set; }
        public string Statusbordercolor { get; set; }
        public string Statusfontcolor { get; set; }
        public int Statusfontsize { get; set; }
        public string CreateByName { get;  set; }
        public string UpdateByName { get;  set; }
    }
    public class AgreementModel
    {

    }
    public class AgreementSearch
    {
        public string AgmNo { get; set; }
        public string Status { get; set; }
        public string RefContractNo { get; set; }
        public string DeptCode { get; set; }
        public string SupCodeName { get; set; }
        public string RefAgmNo { get; set; }
        public DateTime? SetstartDate { get; set; }
        public DateTime? SetEndDate { get; set; }
        public string AgmType { get;  set; }
        public Boolean? ActiveFlag { get;  set; }
        public int? ApproveUserId { get;  set; }
    }

    public class AgmSelectedTab_Result
    {
        public long? AgmID { get; set; }
        public Boolean CreditFlag { get; set; }
        public Boolean RebateFlag { get; set; }
        public Boolean MarketingFeeFlag { get; set; }
        public Boolean DamageFlag { get; set; }
        public Boolean DCChargeFlag { get; set; }
        public Boolean CustomizeFlag { get; set; }
        public Boolean NewStoreFlag { get; set; }
        public Boolean NewProductFlag { get; set; }
        public Boolean CreditTermFlag { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
    public class AgmHeader_Result
    {
        public long? AgmID { get; set; }
        public string AgmNo { get; set; }
        public string Description { get; set; }
        public DateTime DocDate { get; set; }
        public string DeptCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? Status { get; set; }
        public string StatusCode { get; set; }
        public string StatusName { get; set; }
        public int? ReferenceContractID { get; set; }
        public string ReferenceContractNo { get; set; }
        public string AgmType { get; set; }
        public long? ReferenceAgmID { get; set; }
        public string ReferenceAgmNo { get; set; }
        public string Subject { get; set; }
        public string Remark { get; set; }
        public int? SupplierID { get; set; }
        public string SupplierCode { get; set; }
        public bool SendSupplierFlag { get; set; }
        public int? CreateBy { get; set; }
    
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? SubmitBy { get; set; }
        public DateTime? SubmitDate { get; set; }
        public int? ManagerApproveStatus { get; set; }
        public int? SupplierApproveStatus { get; set; }
        public int? SupplierApproveBy { get; set; }
        public DateTime? SupplierApproveDate { get; set; }
        public string RejectedReason { get; set; }
        public int? RejectedBy { get; set; }
        public DateTime? RejectDate { get; set; }
        public string SupplierName { get;  set; }
        public string ManagerApproveStatusCode { get; set; }
        public string ManagerApproveStatusName { get; set; }
        public string SupplierApproveStatusCode { get; set; }
        public string SupplierApproveStatusName { get; set; }
        public AgmSelectedTab_Result AgmSelectedTab { get; set; }
        public List<AgmSignature_Result> AgmSignature { get; set; }
        public List<AgmAttachment_Result> AgmAttachment { get; set; }
        public List<AgmCredit_Result> AgmCredit { get; set; }
        public List<AgmRebate_Result> AgmRebate { get; set; }
        public List<AgmMarketingFee_Result> AgmMarketingFee { get;  set; }
        public AgmDCCharge_Result AgmDCCharge { get;  set; }
        public AgmDamage_Result AgmDamage { get;  set; }
        public List<AgmOther_Result> AgmOther { get;  set; }
        public string Mode { get; set; }
        public string DeptName { get;  set; }
        public int? HeaderApproveStatus { get;  set; }
        public string HeaderStatusCode { get;  set; }
        public string StatusBgColor { get;  set; }
        public string StatusBorderColor { get;  set; }
        public string StatusFontColor { get;  set; }
        public int? StatusFontSize { get;  set; }
        public List<AgmItem> AgmItem { get;  set; }
    }
    public class AgmItem
    {
        public long? AgmItemID { get; set; }
        public long? AgmID { get; set; }
        public int? ItemLineNo { get; set; }
        public string CateCode { get; set; }
        public string SubCateCode { get; set; }
        public string SubCateName { get; set; }
        public string CateName { get; set; }
    }
        public class AgmSignature_Result
    {
        public long? ID { get; set; }
        public long? AgmID { get; set; }
        public int? LineNo { get; set; }
        public bool VendorFlag { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string SignatureType { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? SCGUserID { get; set; }
        public string Email { get;  set; }
    }
    public class AgmAttachment_Result
    {
        public long? ID { get; set; }
        public long? AgmID { get; set; }
        public int? LineNo { get; set; }
        public string Decription { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? DeleteFlag { get; set; }
        //public Buffer[] File { get; set; }
        //public IFormFile File { get; set; }
    }
    public class AgmCredit_Result
    {
        public long? AgmCreditID { get; set; }
        public long? AgmID { get; set; }
        public string Year { get; set; }
        public string Period { get; set; }
        public string CateCode { get; set; }
        public string CategoryName { get; set; }
        public string SubCateCode { get; set; }
        public string SubCategoryName { get; set; }
        public decimal? Value1 { get; set; }
        public decimal? Value2 { get; set; }
        public decimal? Value3 { get; set; }
        public decimal? Value4 { get; set; }
        public decimal? Value5 { get; set; }
        public decimal? Value6 { get; set; }
        public decimal? Value7 { get; set; }
        public decimal? Value8 { get; set; }
        public decimal? Value9 { get; set; }
        public decimal? Value10 { get; set; }
        public decimal? Value11 { get; set; }
        public decimal? Value12 { get; set; }
        public int? ManagerApproveID { get; set; }
        public string ManagerRejectReason { get; set; }
        public string SupplierRejectReason { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string PeriodName { get;  set; }
        public int? NoofColumn { get;  set; }
        public int? ManagerApproveStatus { get;  set; }
        public string StatusCode { get;  set; }
        public string StatusBgColor { get;  set; }
        public string StatusBorderColor { get;  set; }
        public string StatusFontColor { get;  set; }
        public int? StatusFontSize { get;  set; }
    }
    public class AgmRebate_Result
    {
        public long? AgmRebateID{ get; set; }
        public long? AgmID { get; set; }
        public int? RebateNo { get; set; }
        public string RebateType { get; set; }
        public string SupType { get; set; }
        public string CalBy { get; set; }
        public string CalByName { get; set; }
        public string Period { get; set; }
        public string PeriodName { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentMethodName { get; set; }
        public int? ManagerApproveID { get; set; }
        public string ManagerRejectReason { get; set; }
        public string SupplierRejectReason { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get;  set; }
        public List<AgmRebateStep_Result> RebateStep { get;  set; }
        public List<AgmRebateItem_Result> SubItems { get;  set; }
        public string RebateTypeName { get;  set; }
        public string SupTypeName { get;  set; }
        public string Unit { get;  set; }
        public int? ManagerApproveStatus { get; set; }
        public string StatusCode { get; set; }
        public string StatusBgColor { get; set; }
        public string StatusBorderColor { get; set; }
        public string StatusFontColor { get; set; }
        public int? StatusFontSize { get; set; }
    }
    public class AgmMarketingFee_Result
    {
        public long? AgmMarketingFeeID { get; set; }
        public long? AgmID { get; set; }
        public string Description { get; set; }
        public int? MKTLineNo { get; set; }
        public string SupType { get; set; }
        public string SupTypeName { get; set; }
        public string CalBy { get; set; }
        public string CalByName { get; set; }
        public decimal? SupAmount { get; set; }
        public decimal? TargetAmount { get; set; }
        public string Period { get; set; }
        public string PeriodName { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentMethodName { get; set; }
        public int? ManagerApproveID { get; set; }
        public string ManagerRejectReason { get; set; }
        public string SupplierRejectReason { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Unit {get; set;}
        public int? ManagerApproveStatus { get; set; }
        public string StatusCode { get; set; }
        public string StatusBgColor { get; set; }
        public string StatusBorderColor { get; set; }
        public string StatusFontColor { get; set; }
        public int? StatusFontSize { get; set; }
    }
        public class AgmDCCharge_Result
    {
        public long? AgmDCChargeID   { get; set; }
        public long? AgmID                { get; set; }
        public string SupType                 { get; set; }
        public string SupTypeName             { get; set; }
        public string CalBy                   { get; set; }
        public string CalByName               { get; set; }
        public decimal? SupAmount               { get; set; }
        public string Period                  { get; set; }
        public string PeriodName              { get; set; }
        public string PaymentMethod           { get; set; }
        public string PaymentMethodName       { get; set; }
        public string Note                    { get; set; } 
        public int? ManagerApproveID { get; set; }
        public string ManagerRejectReason { get; set; }
        public string SupplierRejectReason { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Unit {get; set;}
        public int? ManagerApproveStatus { get; set; }
        public string StatusCode { get; set; }
        public string StatusBgColor { get; set; }
        public string StatusBorderColor { get; set; }
        public string StatusFontColor { get; set; }
        public int? StatusFontSize { get; set; }
    }  
    public class AgmDamage_Result
    {
        public long? AgmDamageID { get; set; }
        public long? AgmID { get; set; }
        public string SupType { get; set; }
        public string SupTypeName { get; set; }
        public string CalBy { get; set; }
        public string CalByName { get; set; }
        public decimal? SupAmount { get; set; }
        public string Note { get; set; }
        public int? ManagerApproveID { get; set; }
        public string ManagerRejectReason { get; set; }
        public string SupplierRejectReason { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Unit {get; set;}
        public int? ManagerApproveStatus { get; set; }
        public string StatusCode { get; set; }
        public string StatusBgColor { get; set; }
        public string StatusBorderColor { get; set; }
        public string StatusFontColor { get; set; }
        public int? StatusFontSize { get; set; }
    }
    public class AgmOther_Result
    {
        public long? AgmOtherID            { get; set; }
        public long? AgmID                 { get; set; }
        public string OtherType             { get; set; }
        public string Description           { get; set; }
        public string SupType               { get; set; }
        public string SupTypeName           { get; set; }
        public string CalBy                 { get; set; }
        public string CalByName             { get; set; }
        public decimal? SupAmount             { get; set; }
        public string PaymentMethod         { get; set; }
        public string PaymentMethodName     { get; set; }
        public int? OldCreditTerm         { get; set; }
        public int? NewCreditTerm { get; set; }
        public int? ManagerApproveID { get; set; }
        public string ManagerRejectReason { get; set; }
        public string SupplierRejectReason { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Unit {get; set;}
        public int? ManagerApproveStatus { get; set; }
        public string StatusCode { get; set; }
        public string StatusBgColor { get; set; }
        public string StatusBorderColor { get; set; }
        public string StatusFontColor { get; set; }
        public int? StatusFontSize { get; set; }
    }
    public class AgmReport {
        //[JsonProperty(PropertyName = "ragmid")]

    }
    public class AgmAprrove_Result
    {
public string ActionName { get; set; }
        public string Action { get; set; }
        public DateTime? ActionDate { get; set; }
        public int? Status { get; set; }
        public string StatusName { get; set; }
        public int? CompleteFlag { get; set; }
        public int? Seq { get; set; }
        public string Statusbgcolor { get;  set; }
        public string Statusbordercolor { get;  set; }
        public string Statusfontcolor { get;  set; }
        public int Statusfontsize { get;  set; }
    }
        public class AgmRebateStep_Result
    {
        public long? AgmRebateStepID { get; set; }
        public long? AgmRebateID  { get; set; }
        public long? AgmID { get; set; }
        public int? StepLineNo { get; set; }
        public decimal? StepAmount { get; set; }
        public decimal? TargetAmount { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
    public class AgmRebateItem_Result
    {
        public long? AgmRebateItemID { get; set; }
        public long? AgmRebateID  { get; set; }
        public long? AgmID { get; set; }
        public int? ItemLineNo { get; set; }
        public string CateCode { get; set; }
        public string SubCateCode { get; set; }
        public string SubCateName { get; set; }
        public string CateName { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }

}
 public class UpdateStatusAgreement
    {
        public string AgmtId { get; set; }
        public string StatusID { get; set; }
    }

public class ApprovAgmModel
{
    public long? AgmId { get; set; }
    public string TabCode { get; set; }
    public int? Updateby { get; set; }
    public List<ApprovAgmDetail> ApprovAgmDetail { get; set; }
}
public class ApprovAgmDetail
{
    public long AgmId { get; set; }
    public string TabCode { get; set; }
    public bool Approveflag { get; set; }
    public string Rejectreason { get; set; }
    public int? Updateby { get; set; }
}
