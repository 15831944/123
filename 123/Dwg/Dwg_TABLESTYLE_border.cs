//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_TABLESTYLE_border : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_TABLESTYLE_border(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_TABLESTYLE_border obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_TABLESTYLE_border() {
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
          LibreDWGPINVOKE.delete_Dwg_TABLESTYLE_border(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public short linewt {
    set {
      LibreDWGPINVOKE.Dwg_TABLESTYLE_border_linewt_set(swigCPtr, value);
    } 
    get {
      short ret = LibreDWGPINVOKE.Dwg_TABLESTYLE_border_linewt_get(swigCPtr);
      return ret;
    } 
  }

  public byte visible {
    set {
      LibreDWGPINVOKE.Dwg_TABLESTYLE_border_visible_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_TABLESTYLE_border_visible_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Color color {
    set {
      LibreDWGPINVOKE.Dwg_TABLESTYLE_border_color_set(swigCPtr, Dwg_Color.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_TABLESTYLE_border_color_get(swigCPtr);
      Dwg_Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Color(cPtr, false);
      return ret;
    } 
  }

  public Dwg_TABLESTYLE_rowstyles parent {
    set {
      LibreDWGPINVOKE.Dwg_TABLESTYLE_border_parent_set(swigCPtr, Dwg_TABLESTYLE_rowstyles.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_TABLESTYLE_border_parent_get(swigCPtr);
      Dwg_TABLESTYLE_rowstyles ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_TABLESTYLE_rowstyles(cPtr, false);
      return ret;
    } 
  }

  public Dwg_TABLESTYLE_border() : this(LibreDWGPINVOKE.new_Dwg_TABLESTYLE_border(), true) {
  }

}
