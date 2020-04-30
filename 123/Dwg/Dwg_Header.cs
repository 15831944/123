//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Header : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Header(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Header obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Header() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LibreDWGPINVOKE.delete_Dwg_Header(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Version_Type version {
    set {
      LibreDWGPINVOKE.Dwg_Header_version_set(swigCPtr, (int)value);
    } 
    get {
      Dwg_Version_Type ret = (Dwg_Version_Type)LibreDWGPINVOKE.Dwg_Header_version_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Version_Type from_version {
    set {
      LibreDWGPINVOKE.Dwg_Header_from_version_set(swigCPtr, (int)value);
    } 
    get {
      Dwg_Version_Type ret = (Dwg_Version_Type)LibreDWGPINVOKE.Dwg_Header_from_version_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char zero_5 {
    set {
      LibreDWGPINVOKE.Dwg_Header_zero_5_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Header_zero_5_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public byte is_maint {
    set {
      LibreDWGPINVOKE.Dwg_Header_is_maint_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Header_is_maint_get(swigCPtr);
      return ret;
    } 
  }

  public byte zero_one_or_three {
    set {
      LibreDWGPINVOKE.Dwg_Header_zero_one_or_three_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Header_zero_one_or_three_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_short unknown_s {
    set {
      LibreDWGPINVOKE.Dwg_Header_unknown_s_set(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Header_unknown_s_get(swigCPtr);
      SWIGTYPE_p_unsigned_short ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_short(cPtr, false);
      return ret;
    } 
  }

  public uint thumbnail_address {
    set {
      LibreDWGPINVOKE.Dwg_Header_thumbnail_address_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Header_thumbnail_address_get(swigCPtr);
      return ret;
    } 
  }

  public byte dwg_version {
    set {
      LibreDWGPINVOKE.Dwg_Header_dwg_version_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Header_dwg_version_get(swigCPtr);
      return ret;
    } 
  }

  public byte maint_version {
    set {
      LibreDWGPINVOKE.Dwg_Header_maint_version_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Header_maint_version_get(swigCPtr);
      return ret;
    } 
  }

  public ushort codepage {
    set {
      LibreDWGPINVOKE.Dwg_Header_codepage_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Header_codepage_get(swigCPtr);
      return ret;
    } 
  }

  public byte unknown_0 {
    set {
      LibreDWGPINVOKE.Dwg_Header_unknown_0_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Header_unknown_0_get(swigCPtr);
      return ret;
    } 
  }

  public byte app_dwg_version {
    set {
      LibreDWGPINVOKE.Dwg_Header_app_dwg_version_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Header_app_dwg_version_get(swigCPtr);
      return ret;
    } 
  }

  public byte app_maint_version {
    set {
      LibreDWGPINVOKE.Dwg_Header_app_maint_version_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Header_app_maint_version_get(swigCPtr);
      return ret;
    } 
  }

  public uint security_type {
    set {
      LibreDWGPINVOKE.Dwg_Header_security_type_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Header_security_type_get(swigCPtr);
      return ret;
    } 
  }

  public uint rl_1c_address {
    set {
      LibreDWGPINVOKE.Dwg_Header_rl_1c_address_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Header_rl_1c_address_get(swigCPtr);
      return ret;
    } 
  }

  public uint summaryinfo_address {
    set {
      LibreDWGPINVOKE.Dwg_Header_summaryinfo_address_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Header_summaryinfo_address_get(swigCPtr);
      return ret;
    } 
  }

  public uint vbaproj_address {
    set {
      LibreDWGPINVOKE.Dwg_Header_vbaproj_address_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Header_vbaproj_address_get(swigCPtr);
      return ret;
    } 
  }

  public uint rl_28_80 {
    set {
      LibreDWGPINVOKE.Dwg_Header_rl_28_80_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Header_rl_28_80_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_sections {
    set {
      LibreDWGPINVOKE.Dwg_Header_num_sections_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Header_num_sections_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Section section {
    set {
      LibreDWGPINVOKE.Dwg_Header_section_set(swigCPtr, Dwg_Section.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Header_section_get(swigCPtr);
      Dwg_Section ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Section(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Section_InfoHdr section_infohdr {
    set {
      LibreDWGPINVOKE.Dwg_Header_section_infohdr_set(swigCPtr, Dwg_Section_InfoHdr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Header_section_infohdr_get(swigCPtr);
      Dwg_Section_InfoHdr ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Section_InfoHdr(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Section_Info section_info {
    set {
      LibreDWGPINVOKE.Dwg_Header_section_info_set(swigCPtr, Dwg_Section_Info.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Header_section_info_get(swigCPtr);
      Dwg_Section_Info ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Section_Info(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Header() : this(LibreDWGPINVOKE.new_Dwg_Header(), true) {
  }

}