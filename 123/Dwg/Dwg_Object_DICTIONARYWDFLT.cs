//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_DICTIONARYWDFLT : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_DICTIONARYWDFLT(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_DICTIONARYWDFLT obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_DICTIONARYWDFLT() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_DICTIONARYWDFLT(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_DICTIONARYWDFLT_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_DICTIONARYWDFLT_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public uint numitems {
    set {
      LibreDWGPINVOKE.Dwg_Object_DICTIONARYWDFLT_numitems_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_DICTIONARYWDFLT_numitems_get(swigCPtr);
      return ret;
    } 
  }

  public ushort cloning {
    set {
      LibreDWGPINVOKE.Dwg_Object_DICTIONARYWDFLT_cloning_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_DICTIONARYWDFLT_cloning_get(swigCPtr);
      return ret;
    } 
  }

  public byte hard_owner {
    set {
      LibreDWGPINVOKE.Dwg_Object_DICTIONARYWDFLT_hard_owner_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_DICTIONARYWDFLT_hard_owner_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_char texts {
    set {
      LibreDWGPINVOKE.Dwg_Object_DICTIONARYWDFLT_texts_set(swigCPtr, SWIGTYPE_p_p_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_DICTIONARYWDFLT_texts_get(swigCPtr);
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p__dwg_object_ref itemhandles {
    set {
      LibreDWGPINVOKE.Dwg_Object_DICTIONARYWDFLT_itemhandles_set(swigCPtr, SWIGTYPE_p_p__dwg_object_ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_DICTIONARYWDFLT_itemhandles_get(swigCPtr);
      SWIGTYPE_p_p__dwg_object_ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p__dwg_object_ref(cPtr, false);
      return ret;
    } 
  }

  public uint cloning_r14 {
    set {
      LibreDWGPINVOKE.Dwg_Object_DICTIONARYWDFLT_cloning_r14_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_DICTIONARYWDFLT_cloning_r14_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref defaultid {
    set {
      LibreDWGPINVOKE.Dwg_Object_DICTIONARYWDFLT_defaultid_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_DICTIONARYWDFLT_defaultid_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_DICTIONARYWDFLT() : this(LibreDWGPINVOKE.new_Dwg_Object_DICTIONARYWDFLT(), true) {
  }

}
