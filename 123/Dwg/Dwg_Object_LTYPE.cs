//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_LTYPE : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_LTYPE(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_LTYPE obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_LTYPE() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_LTYPE(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_LTYPE_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_LTYPE_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public ushort flag {
    set {
      LibreDWGPINVOKE.Dwg_Object_LTYPE_flag_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_LTYPE_flag_get(swigCPtr);
      return ret;
    } 
  }

  public string name {
    set {
      LibreDWGPINVOKE.Dwg_Object_LTYPE_name_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_LTYPE_name_get(swigCPtr);
      return ret;
    } 
  }

  public ushort used {
    set {
      LibreDWGPINVOKE.Dwg_Object_LTYPE_used_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_LTYPE_used_get(swigCPtr);
      return ret;
    } 
  }

  public byte is_xref_ref {
    set {
      LibreDWGPINVOKE.Dwg_Object_LTYPE_is_xref_ref_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_LTYPE_is_xref_ref_get(swigCPtr);
      return ret;
    } 
  }

  public ushort is_xref_resolved {
    set {
      LibreDWGPINVOKE.Dwg_Object_LTYPE_is_xref_resolved_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_LTYPE_is_xref_resolved_get(swigCPtr);
      return ret;
    } 
  }

  public byte is_xref_dep {
    set {
      LibreDWGPINVOKE.Dwg_Object_LTYPE_is_xref_dep_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_LTYPE_is_xref_dep_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref xref {
    set {
      LibreDWGPINVOKE.Dwg_Object_LTYPE_xref_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_LTYPE_xref_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public string description {
    set {
      LibreDWGPINVOKE.Dwg_Object_LTYPE_description_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_LTYPE_description_get(swigCPtr);
      return ret;
    } 
  }

  public double pattern_len {
    set {
      LibreDWGPINVOKE.Dwg_Object_LTYPE_pattern_len_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_LTYPE_pattern_len_get(swigCPtr);
      return ret;
    } 
  }

  public byte alignment {
    set {
      LibreDWGPINVOKE.Dwg_Object_LTYPE_alignment_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_LTYPE_alignment_get(swigCPtr);
      return ret;
    } 
  }

  public byte num_dashes {
    set {
      LibreDWGPINVOKE.Dwg_Object_LTYPE_num_dashes_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_LTYPE_num_dashes_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_LTYPE_dash dashes {
    set {
      LibreDWGPINVOKE.Dwg_Object_LTYPE_dashes_set(swigCPtr, Dwg_LTYPE_dash.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_LTYPE_dashes_get(swigCPtr);
      Dwg_LTYPE_dash ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_LTYPE_dash(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_double dashes_r11 {
    set {
      LibreDWGPINVOKE.Dwg_Object_LTYPE_dashes_r11_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_LTYPE_dashes_r11_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public byte has_strings_area {
    set {
      LibreDWGPINVOKE.Dwg_Object_LTYPE_has_strings_area_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_LTYPE_has_strings_area_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char strings_area {
    set {
      LibreDWGPINVOKE.Dwg_Object_LTYPE_strings_area_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_LTYPE_strings_area_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_LTYPE() : this(LibreDWGPINVOKE.new_Dwg_Object_LTYPE(), true) {
  }

}
