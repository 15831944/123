//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_PERSUBENTMGR : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_PERSUBENTMGR(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_PERSUBENTMGR obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_PERSUBENTMGR() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_PERSUBENTMGR(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_PERSUBENTMGR_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_PERSUBENTMGR_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public uint class_version {
    set {
      LibreDWGPINVOKE.Dwg_Object_PERSUBENTMGR_class_version_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_PERSUBENTMGR_class_version_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl1 {
    set {
      LibreDWGPINVOKE.Dwg_Object_PERSUBENTMGR_unknown_bl1_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_PERSUBENTMGR_unknown_bl1_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl2 {
    set {
      LibreDWGPINVOKE.Dwg_Object_PERSUBENTMGR_unknown_bl2_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_PERSUBENTMGR_unknown_bl2_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl3 {
    set {
      LibreDWGPINVOKE.Dwg_Object_PERSUBENTMGR_unknown_bl3_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_PERSUBENTMGR_unknown_bl3_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl4 {
    set {
      LibreDWGPINVOKE.Dwg_Object_PERSUBENTMGR_unknown_bl4_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_PERSUBENTMGR_unknown_bl4_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl5 {
    set {
      LibreDWGPINVOKE.Dwg_Object_PERSUBENTMGR_unknown_bl5_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_PERSUBENTMGR_unknown_bl5_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_bl6 {
    set {
      LibreDWGPINVOKE.Dwg_Object_PERSUBENTMGR_unknown_bl6_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_PERSUBENTMGR_unknown_bl6_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_PERSUBENTMGR() : this(LibreDWGPINVOKE.new_Dwg_Object_PERSUBENTMGR(), true) {
  }

}
