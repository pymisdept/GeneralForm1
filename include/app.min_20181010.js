﻿$(function(){$("#myform").validate({rules:{fUpload1:{required:!0,extension:"pdf|doc|docx",filesize:10485760},fUpload2:{extension:"pdf|doc|docx",filesize:10485760},fUpload3:{extension:"pdf|doc|docx",filesize:10485760},fUpload4:{extension:"pdf|doc|docx",filesize:10485760},fUpload5:{extension:"pdf|doc|docx",filesize:10485760},PosApplied:{required:!0},ptitle:{required:!0},EngSurName:{required:!0},EngOtherName:{required:!0},email:{required:!0,email:!0},phone:{required:!0},checkDeclaration:{custRequired:!0},addr_ds:{required:!0}},messages:{ptitle:{required:"請選擇稱謂 Please select Salutation"},PosApplied:{required:"請選擇申請職位 Please select the Position"},EngSurName:{required:"請填寫英文姓氏 Please enter English Surname"},EngOtherName:{required:"請填寫英文名字 Please enter English Other Name"},email:{required:"請填寫電郵地址 Please enter Email address",email:"請填寫正確的電郵地址 Please enter a valid Email Address"},phone:{required:"請填寫電話 Please enter Phone No."},fUpload1:{required:"請上載PDF / Word 檔案 Please upload PDF / Word File",extension:"請上載PDF / Word 檔案 Please upload PDF / Word File",filesize:"每個上載檔案不得超過10MB Each file size must not exceed 10MB"},fUpload2:{extension:"請上載PDF / Word 檔案 Please upload PDF / Word File",filesize:"每個上載檔案不得超過10MB Each file size must not exceed 10MB"},fUpload3:{extension:"請上載PDF / Word 檔案 Please upload PDF / Word File",filesize:"每個上載檔案不得超過10MB Each file size must not exceed 10MB"},fUpload4:{extension:"請上載PDF / Word 檔案 Please upload PDF / Word File",filesize:"每個上載檔案不得超過10MB Each file size must not exceed 10MB"},fUpload5:{extension:"請上載PDF / Word 檔案 Please upload PDF / Word File",filesize:"每個上載檔案不得超過10MB Each file size must not exceed 10MB"},checkDeclaration:{custRequired:"* 請細閱以下內容 Please read this carefully"},addr_st:{required:"請填寫街道 Please enter Street"},addr_ds:{required:"請選擇地區 Please select District"},addr_bd:{required:"請填寫大廈/屋苑 Please enter Building/Estate"}}});$.validator.addMethod("custRequired",$.validator.methods.required,"*"),$.validator.addMethod("custDigits",$.validator.methods.digits,"*"),$.validator.addMethod("custMinLgt",$.validator.methods.minlength,"*"),$.validator.addMethod("custMaxLgt",$.validator.methods.maxlength,"*"),$.validator.addMethod("custRange",$.validator.methods.range,"*"),$.validator.addMethod("custNum",$.validator.methods.number,"*"),$.validator.addMethod("custLessThan",function(e,t,i){if(this.optional(t))return!0;var d,a=t.name;"ctrl_txt_GRC"==a?d=$("#ctrl_txt_GRP"):(stArr=a.split("_"),d=$("#ctrlDynamic_txt_GRP_6_"+stArr[4]));var l=parseFloat(e);return parseFloat($(d).val())<=l},"*"),$.validator.addMethod("email",function(e,t){return this.optional(t)||/[a-z]+@[a-z]+\.[a-z]+/.test(e)}),$.validator.addMethod("filesize",function(e,t,i){return this.optional(t)||t.files[0].size<=i}),jQuery.validator.addClassRules({formdl:{custRequired:!0},formtx:{custRequired:!0},formtxm:{custRequired:!0,custDigits:!0,custMinLgt:2,custMaxLgt:2,custRange:[1,12]},formtxy:{custRequired:!0,custDigits:!0,custMinLgt:4,custMaxLgt:4,custRange:[1900,2099]},formtxn:{custRequired:!0,custNum:!0,custRange:[1,1e3]},formG:{custLessThan:"#ctrl_txt_GRP"}}),$(".resdclass").change(function(){var e,t,i,d,a=$(this).val(),l=this.id;"ctrl_dlist_RES"==l?(e=$("#ctrl_txt_GRD"),t=$("#ctrl_txt_GRP"),i=$("#ctrl_txt_GRC"),l1=$("#ctrl_lbl_SLH2")):(d=l.split("_"),e=$("#ctrlDynamic_txt_GRD_6_"+d[4]),t=$("#ctrlDynamic_txt_GRP_6_"+d[4]),i=$("#ctrlDynamic_txt_GRC_6_"+d[4]),l1=$("#ctrlDynamic_lbl_SLH_6_"+d[4])),"GPA"==a?(e.val(""),e.hide(),t.show(),i.show(),l1.show()):"GRA"==a?(t.val(""),i.val(""),e.show(),t.hide(),i.hide(),l1.hide()):(e.val(""),t.val(""),i.val(""),e.hide(),t.hide(),i.hide(),l1.hide())}),$(".educlass").change(function(){var e,t,i=$(this).val(),d=this.id;"ctrl_dlist_EDU"==d?e=$("#ctrl_txt_EDO"):(t=d.split("_"),e=$("#ctrlDynamic_txt_EDO_1_"+t[4])),"OTH"==i?e.show():(e.hide(),e.val(""))}),$(".schclass").change(function(){var e,t,i=$(this).val(),d=this.id;"ctrl_dlist_SCH"==d?e=$("#ctrl_txt_SCO"):(t=d.split("_"),e=$("#ctrlDynamic_txt_SCO_2_"+t[4])),"OTH"==i?e.show():(e.hide(),e.val(""))})});