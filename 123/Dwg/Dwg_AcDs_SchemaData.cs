//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_AcDs_SchemaData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_AcDs_SchemaData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_AcDs_SchemaData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_AcDs_SchemaData() {
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
          LibreDWGPINVOKE.delete_Dwg_AcDs_SchemaData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint num_uprops {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_SchemaData_num_uprops_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AcDs_SchemaData_num_uprops_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_AcDs_SchemaData_UProp uprops {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_SchemaData_uprops_set(swigCPtr, Dwg_AcDs_SchemaData_UProp.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_AcDs_SchemaData_uprops_get(swigCPtr);
      Dwg_AcDs_SchemaData_UProp ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_AcDs_SchemaData_UProp(cPtr, false);
      return ret;
    } 
  }

  public uint num_schemas {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_SchemaData_num_schemas_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AcDs_SchemaData_num_schemas_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_AcDs_Schema schemas {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_SchemaData_schemas_set(swigCPtr, Dwg_AcDs_Schema.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_AcDs_SchemaData_schemas_get(swigCPtr);
      Dwg_AcDs_Schema ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_AcDs_Schema(cPtr, false);
      return ret;
    } 
  }

  public uint num_propnames {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_SchemaData_num_propnames_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AcDs_SchemaData_num_propnames_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_char propnames {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_SchemaData_propnames_set(swigCPtr, SWIGTYPE_p_p_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_AcDs_SchemaData_propnames_get(swigCPtr);
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public Dwg_AcDs_SchemaData() : this(LibreDWGPINVOKE.new_Dwg_AcDs_SchemaData(), true) {
  }

}
