//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_LAYER_entry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_LAYER_entry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_LAYER_entry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_LAYER_entry() {
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
          LibreDWGPINVOKE.delete_Dwg_LAYER_entry(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint idxlong {
    set {
      LibreDWGPINVOKE.Dwg_LAYER_entry_idxlong_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_LAYER_entry_idxlong_get(swigCPtr);
      return ret;
    } 
  }

  public string layername {
    set {
      LibreDWGPINVOKE.Dwg_LAYER_entry_layername_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_LAYER_entry_layername_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_LAYER_INDEX parent {
    set {
      LibreDWGPINVOKE.Dwg_LAYER_entry_parent_set(swigCPtr, Dwg_Object_LAYER_INDEX.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_LAYER_entry_parent_get(swigCPtr);
      Dwg_Object_LAYER_INDEX ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_LAYER_INDEX(cPtr, false);
      return ret;
    } 
  }

  public Dwg_LAYER_entry() : this(LibreDWGPINVOKE.new_Dwg_LAYER_entry(), true) {
  }

}
