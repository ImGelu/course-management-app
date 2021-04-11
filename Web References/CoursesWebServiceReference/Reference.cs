﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Proiect.CoursesWebServiceReference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CoursesWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class CoursesWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetUsersOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetUserByEmailOperationCompleted;
        
        private System.Threading.SendOrPostCallback CheckLoginOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback EditUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteUserOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CoursesWebService() {
            this.Url = global::Proiect.Properties.Settings.Default.Proiect_CoursesWebServiceReference_CoursesWebService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetUsersCompletedEventHandler GetUsersCompleted;
        
        /// <remarks/>
        public event GetUserCompletedEventHandler GetUserCompleted;
        
        /// <remarks/>
        public event GetUserByEmailCompletedEventHandler GetUserByEmailCompleted;
        
        /// <remarks/>
        public event CheckLoginCompletedEventHandler CheckLoginCompleted;
        
        /// <remarks/>
        public event AddUserCompletedEventHandler AddUserCompleted;
        
        /// <remarks/>
        public event EditUserCompletedEventHandler EditUserCompleted;
        
        /// <remarks/>
        public event DeleteUserCompletedEventHandler DeleteUserCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUsers", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public User[] GetUsers() {
            object[] results = this.Invoke("GetUsers", new object[0]);
            return ((User[])(results[0]));
        }
        
        /// <remarks/>
        public void GetUsersAsync() {
            this.GetUsersAsync(null);
        }
        
        /// <remarks/>
        public void GetUsersAsync(object userState) {
            if ((this.GetUsersOperationCompleted == null)) {
                this.GetUsersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUsersOperationCompleted);
            }
            this.InvokeAsync("GetUsers", new object[0], this.GetUsersOperationCompleted, userState);
        }
        
        private void OnGetUsersOperationCompleted(object arg) {
            if ((this.GetUsersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUsersCompleted(this, new GetUsersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public User GetUser(int id) {
            object[] results = this.Invoke("GetUser", new object[] {
                        id});
            return ((User)(results[0]));
        }
        
        /// <remarks/>
        public void GetUserAsync(int id) {
            this.GetUserAsync(id, null);
        }
        
        /// <remarks/>
        public void GetUserAsync(int id, object userState) {
            if ((this.GetUserOperationCompleted == null)) {
                this.GetUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUserOperationCompleted);
            }
            this.InvokeAsync("GetUser", new object[] {
                        id}, this.GetUserOperationCompleted, userState);
        }
        
        private void OnGetUserOperationCompleted(object arg) {
            if ((this.GetUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUserCompleted(this, new GetUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUserByEmail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public User GetUserByEmail(string email) {
            object[] results = this.Invoke("GetUserByEmail", new object[] {
                        email});
            return ((User)(results[0]));
        }
        
        /// <remarks/>
        public void GetUserByEmailAsync(string email) {
            this.GetUserByEmailAsync(email, null);
        }
        
        /// <remarks/>
        public void GetUserByEmailAsync(string email, object userState) {
            if ((this.GetUserByEmailOperationCompleted == null)) {
                this.GetUserByEmailOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUserByEmailOperationCompleted);
            }
            this.InvokeAsync("GetUserByEmail", new object[] {
                        email}, this.GetUserByEmailOperationCompleted, userState);
        }
        
        private void OnGetUserByEmailOperationCompleted(object arg) {
            if ((this.GetUserByEmailCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUserByEmailCompleted(this, new GetUserByEmailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CheckLogin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public User CheckLogin(string email, string password) {
            object[] results = this.Invoke("CheckLogin", new object[] {
                        email,
                        password});
            return ((User)(results[0]));
        }
        
        /// <remarks/>
        public void CheckLoginAsync(string email, string password) {
            this.CheckLoginAsync(email, password, null);
        }
        
        /// <remarks/>
        public void CheckLoginAsync(string email, string password, object userState) {
            if ((this.CheckLoginOperationCompleted == null)) {
                this.CheckLoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckLoginOperationCompleted);
            }
            this.InvokeAsync("CheckLogin", new object[] {
                        email,
                        password}, this.CheckLoginOperationCompleted, userState);
        }
        
        private void OnCheckLoginOperationCompleted(object arg) {
            if ((this.CheckLoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckLoginCompleted(this, new CheckLoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddUser(User user) {
            this.Invoke("AddUser", new object[] {
                        user});
        }
        
        /// <remarks/>
        public void AddUserAsync(User user) {
            this.AddUserAsync(user, null);
        }
        
        /// <remarks/>
        public void AddUserAsync(User user, object userState) {
            if ((this.AddUserOperationCompleted == null)) {
                this.AddUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddUserOperationCompleted);
            }
            this.InvokeAsync("AddUser", new object[] {
                        user}, this.AddUserOperationCompleted, userState);
        }
        
        private void OnAddUserOperationCompleted(object arg) {
            if ((this.AddUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EditUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void EditUser(User user) {
            this.Invoke("EditUser", new object[] {
                        user});
        }
        
        /// <remarks/>
        public void EditUserAsync(User user) {
            this.EditUserAsync(user, null);
        }
        
        /// <remarks/>
        public void EditUserAsync(User user, object userState) {
            if ((this.EditUserOperationCompleted == null)) {
                this.EditUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEditUserOperationCompleted);
            }
            this.InvokeAsync("EditUser", new object[] {
                        user}, this.EditUserOperationCompleted, userState);
        }
        
        private void OnEditUserOperationCompleted(object arg) {
            if ((this.EditUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EditUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteUser(int id) {
            this.Invoke("DeleteUser", new object[] {
                        id});
        }
        
        /// <remarks/>
        public void DeleteUserAsync(int id) {
            this.DeleteUserAsync(id, null);
        }
        
        /// <remarks/>
        public void DeleteUserAsync(int id, object userState) {
            if ((this.DeleteUserOperationCompleted == null)) {
                this.DeleteUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteUserOperationCompleted);
            }
            this.InvokeAsync("DeleteUser", new object[] {
                        id}, this.DeleteUserOperationCompleted, userState);
        }
        
        private void OnDeleteUserOperationCompleted(object arg) {
            if ((this.DeleteUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class User {
        
        private int idField;
        
        private string nameField;
        
        private string emailField;
        
        private string passwordField;
        
        private Users2Courses[] users2CoursesField;
        
        private Role[] rolesField;
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public Users2Courses[] Users2Courses {
            get {
                return this.users2CoursesField;
            }
            set {
                this.users2CoursesField = value;
            }
        }
        
        /// <remarks/>
        public Role[] Roles {
            get {
                return this.rolesField;
            }
            set {
                this.rolesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Users2Courses {
        
        private int id_userField;
        
        private int id_courseField;
        
        private byte statusField;
        
        private Course courseField;
        
        private User userField;
        
        /// <remarks/>
        public int id_user {
            get {
                return this.id_userField;
            }
            set {
                this.id_userField = value;
            }
        }
        
        /// <remarks/>
        public int id_course {
            get {
                return this.id_courseField;
            }
            set {
                this.id_courseField = value;
            }
        }
        
        /// <remarks/>
        public byte status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public Course Course {
            get {
                return this.courseField;
            }
            set {
                this.courseField = value;
            }
        }
        
        /// <remarks/>
        public User User {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Course {
        
        private int idField;
        
        private int specialization_idField;
        
        private string nameField;
        
        private int study_yearField;
        
        private byte semesterField;
        
        private byte study_levelField;
        
        private byte creditsField;
        
        private int course_hoursField;
        
        private int laboratory_hoursField;
        
        private int seminary_hoursField;
        
        private int project_hoursField;
        
        private string contentField;
        
        private string laboratory_tutorsField;
        
        private string seminary_tutorsField;
        
        private string project_tutorsField;
        
        private Specialization specializationField;
        
        private Users2Courses[] users2CoursesField;
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public int specialization_id {
            get {
                return this.specialization_idField;
            }
            set {
                this.specialization_idField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public int study_year {
            get {
                return this.study_yearField;
            }
            set {
                this.study_yearField = value;
            }
        }
        
        /// <remarks/>
        public byte semester {
            get {
                return this.semesterField;
            }
            set {
                this.semesterField = value;
            }
        }
        
        /// <remarks/>
        public byte study_level {
            get {
                return this.study_levelField;
            }
            set {
                this.study_levelField = value;
            }
        }
        
        /// <remarks/>
        public byte credits {
            get {
                return this.creditsField;
            }
            set {
                this.creditsField = value;
            }
        }
        
        /// <remarks/>
        public int course_hours {
            get {
                return this.course_hoursField;
            }
            set {
                this.course_hoursField = value;
            }
        }
        
        /// <remarks/>
        public int laboratory_hours {
            get {
                return this.laboratory_hoursField;
            }
            set {
                this.laboratory_hoursField = value;
            }
        }
        
        /// <remarks/>
        public int seminary_hours {
            get {
                return this.seminary_hoursField;
            }
            set {
                this.seminary_hoursField = value;
            }
        }
        
        /// <remarks/>
        public int project_hours {
            get {
                return this.project_hoursField;
            }
            set {
                this.project_hoursField = value;
            }
        }
        
        /// <remarks/>
        public string content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
            }
        }
        
        /// <remarks/>
        public string laboratory_tutors {
            get {
                return this.laboratory_tutorsField;
            }
            set {
                this.laboratory_tutorsField = value;
            }
        }
        
        /// <remarks/>
        public string seminary_tutors {
            get {
                return this.seminary_tutorsField;
            }
            set {
                this.seminary_tutorsField = value;
            }
        }
        
        /// <remarks/>
        public string project_tutors {
            get {
                return this.project_tutorsField;
            }
            set {
                this.project_tutorsField = value;
            }
        }
        
        /// <remarks/>
        public Specialization Specialization {
            get {
                return this.specializationField;
            }
            set {
                this.specializationField = value;
            }
        }
        
        /// <remarks/>
        public Users2Courses[] Users2Courses {
            get {
                return this.users2CoursesField;
            }
            set {
                this.users2CoursesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Specialization {
        
        private int idField;
        
        private string nameField;
        
        private int domain_idField;
        
        private Course[] coursesField;
        
        private Domain domainField;
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public int domain_id {
            get {
                return this.domain_idField;
            }
            set {
                this.domain_idField = value;
            }
        }
        
        /// <remarks/>
        public Course[] Courses {
            get {
                return this.coursesField;
            }
            set {
                this.coursesField = value;
            }
        }
        
        /// <remarks/>
        public Domain Domain {
            get {
                return this.domainField;
            }
            set {
                this.domainField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Domain {
        
        private int idField;
        
        private string nameField;
        
        private int faculty_idField;
        
        private Faculty facultyField;
        
        private Specialization[] specializationsField;
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public int faculty_id {
            get {
                return this.faculty_idField;
            }
            set {
                this.faculty_idField = value;
            }
        }
        
        /// <remarks/>
        public Faculty Faculty {
            get {
                return this.facultyField;
            }
            set {
                this.facultyField = value;
            }
        }
        
        /// <remarks/>
        public Specialization[] Specializations {
            get {
                return this.specializationsField;
            }
            set {
                this.specializationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Faculty {
        
        private int idField;
        
        private string nameField;
        
        private string websiteField;
        
        private string logoField;
        
        private Domain[] domainsField;
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string website {
            get {
                return this.websiteField;
            }
            set {
                this.websiteField = value;
            }
        }
        
        /// <remarks/>
        public string logo {
            get {
                return this.logoField;
            }
            set {
                this.logoField = value;
            }
        }
        
        /// <remarks/>
        public Domain[] Domains {
            get {
                return this.domainsField;
            }
            set {
                this.domainsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Role {
        
        private int idField;
        
        private string nameField;
        
        private User[] usersField;
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public User[] Users {
            get {
                return this.usersField;
            }
            set {
                this.usersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetUsersCompletedEventHandler(object sender, GetUsersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUsersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUsersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public User[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((User[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetUserCompletedEventHandler(object sender, GetUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public User Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((User)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetUserByEmailCompletedEventHandler(object sender, GetUserByEmailCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUserByEmailCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUserByEmailCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public User Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((User)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CheckLoginCompletedEventHandler(object sender, CheckLoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckLoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckLoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public User Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((User)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void AddUserCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void EditUserCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DeleteUserCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591