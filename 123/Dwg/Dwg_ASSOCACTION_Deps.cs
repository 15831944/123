//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_ASSOCACTION_Deps : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_ASSOCACTION_Deps(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_ASSOCACTION_Deps obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_ASSOCACTION_Deps() {
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
          LibreDWGPINVOKE.delete_Dwg_ASSOCACTION_Deps(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_ASSOCACTION parent {
    set {
      LibreDWGPINVOKE.Dwg_ASSOCACTION_Deps_parent_set(swigCPtr, Dwg_Object_ASSOCACTION.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_ASSOCACTION_Deps_parent_get(swigCPtr);
      Dwg_Object_ASSOCACTION ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_ASSOCACTION(cPtr, false);
      return ret;
    } 
  }

  public byte is_soft {
    set {
      LibreDWGPINVOKE.Dwg_ASSOCACTION_Deps_is_soft_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_ASSOCACTION_Deps_is_soft_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref dep {
    set {
      LibreDWGPINVOKE.Dwg_ASSOCACTION_Deps_dep_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_ASSOCACTION_Deps_dep_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_ASSOCACTION_Deps() : this(LibreDWGPINVOKE.new_Dwg_ASSOCACTION_Deps(), true) {
  }

}
