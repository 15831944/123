//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_BLOCKVISIBILITYPARAMETER_state : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_BLOCKVISIBILITYPARAMETER_state(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_BLOCKVISIBILITYPARAMETER_state obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_BLOCKVISIBILITYPARAMETER_state() {
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
          LibreDWGPINVOKE.delete_Dwg_BLOCKVISIBILITYPARAMETER_state(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_BLOCKVISIBILITYPARAMETER parent {
    set {
      LibreDWGPINVOKE.Dwg_BLOCKVISIBILITYPARAMETER_state_parent_set(swigCPtr, Dwg_Object_BLOCKVISIBILITYPARAMETER.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_BLOCKVISIBILITYPARAMETER_state_parent_get(swigCPtr);
      Dwg_Object_BLOCKVISIBILITYPARAMETER ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_BLOCKVISIBILITYPARAMETER(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref block {
    set {
      LibreDWGPINVOKE.Dwg_BLOCKVISIBILITYPARAMETER_state_block_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_BLOCKVISIBILITYPARAMETER_state_block_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public uint bl1 {
    set {
      LibreDWGPINVOKE.Dwg_BLOCKVISIBILITYPARAMETER_state_bl1_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_BLOCKVISIBILITYPARAMETER_state_bl1_get(swigCPtr);
      return ret;
    } 
  }

  public uint bl2 {
    set {
      LibreDWGPINVOKE.Dwg_BLOCKVISIBILITYPARAMETER_state_bl2_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_BLOCKVISIBILITYPARAMETER_state_bl2_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_BLOCKVISIBILITYPARAMETER_state() : this(LibreDWGPINVOKE.new_Dwg_BLOCKVISIBILITYPARAMETER_state(), true) {
  }

}
