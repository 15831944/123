//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Color : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Color(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Color obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Color() {
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
          LibreDWGPINVOKE.delete_Dwg_Color(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public short index {
    set {
      LibreDWGPINVOKE.Dwg_Color_index_set(swigCPtr, value);
    } 
    get {
      short ret = LibreDWGPINVOKE.Dwg_Color_index_get(swigCPtr);
      return ret;
    } 
  }

  public ushort flag {
    set {
      LibreDWGPINVOKE.Dwg_Color_flag_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Color_flag_get(swigCPtr);
      return ret;
    } 
  }

  public uint rgb {
    set {
      LibreDWGPINVOKE.Dwg_Color_rgb_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Color_rgb_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref handle {
    set {
      LibreDWGPINVOKE.Dwg_Color_handle_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Color_handle_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public string name {
    set {
      LibreDWGPINVOKE.Dwg_Color_name_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Color_name_get(swigCPtr);
      return ret;
    } 
  }

  public string book_name {
    set {
      LibreDWGPINVOKE.Dwg_Color_book_name_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Color_book_name_get(swigCPtr);
      return ret;
    } 
  }

  public byte alpha_type {
    set {
      LibreDWGPINVOKE.Dwg_Color_alpha_type_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Color_alpha_type_get(swigCPtr);
      return ret;
    } 
  }

  public byte alpha {
    set {
      LibreDWGPINVOKE.Dwg_Color_alpha_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Color_alpha_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Color() : this(LibreDWGPINVOKE.new_Dwg_Color(), true) {
  }

}