//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Entity_PLANESURFACE : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Entity_PLANESURFACE(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Entity_PLANESURFACE obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Entity_PLANESURFACE() {
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
          LibreDWGPINVOKE.delete_Dwg_Entity_PLANESURFACE(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Entity parent {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_parent_set(swigCPtr, Dwg_Object_Entity.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_parent_get(swigCPtr);
      Dwg_Object_Entity ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Entity(cPtr, false);
      return ret;
    } 
  }

  public byte acis_empty {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_acis_empty_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_acis_empty_get(swigCPtr);
      return ret;
    } 
  }

  public byte unknown {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_unknown_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_unknown_get(swigCPtr);
      return ret;
    } 
  }

  public ushort version {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_version_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_version_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_blocks {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_num_blocks_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_num_blocks_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_int block_size {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_block_size_set(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_block_size_get(swigCPtr);
      SWIGTYPE_p_unsigned_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_char encr_sat_data {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_encr_sat_data_set(swigCPtr, SWIGTYPE_p_p_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_encr_sat_data_get(swigCPtr);
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char acis_data {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_acis_data_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_acis_data_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public byte wireframe_data_present {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_wireframe_data_present_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_wireframe_data_present_get(swigCPtr);
      return ret;
    } 
  }

  public byte point_present {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_point_present_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_point_present_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD point {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_point_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_point_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public uint isolines {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_isolines_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_isolines_get(swigCPtr);
      return ret;
    } 
  }

  public byte isoline_present {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_isoline_present_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_isoline_present_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_wires {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_num_wires_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_num_wires_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_3DSOLID_wire wires {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_wires_set(swigCPtr, Dwg_3DSOLID_wire.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_wires_get(swigCPtr);
      Dwg_3DSOLID_wire ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_3DSOLID_wire(cPtr, false);
      return ret;
    } 
  }

  public uint num_silhouettes {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_num_silhouettes_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_num_silhouettes_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_3DSOLID_silhouette silhouettes {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_silhouettes_set(swigCPtr, Dwg_3DSOLID_silhouette.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_silhouettes_get(swigCPtr);
      Dwg_3DSOLID_silhouette ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_3DSOLID_silhouette(cPtr, false);
      return ret;
    } 
  }

  public byte acis_empty2 {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_acis_empty2_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_acis_empty2_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Entity__3DSOLID extra_acis_data {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_extra_acis_data_set(swigCPtr, Dwg_Entity__3DSOLID.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_extra_acis_data_get(swigCPtr);
      Dwg_Entity__3DSOLID ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Entity__3DSOLID(cPtr, false);
      return ret;
    } 
  }

  public uint unknown_2007 {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_unknown_2007_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_unknown_2007_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref history_id {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_history_id_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_history_id_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public byte acis_empty_bit {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_acis_empty_bit_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_acis_empty_bit_get(swigCPtr);
      return ret;
    } 
  }

  public ushort modeler_format_version {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_modeler_format_version_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_modeler_format_version_get(swigCPtr);
      return ret;
    } 
  }

  public ushort u_isolines {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_u_isolines_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_u_isolines_get(swigCPtr);
      return ret;
    } 
  }

  public ushort v_isolines {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_v_isolines_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_v_isolines_get(swigCPtr);
      return ret;
    } 
  }

  public uint class_version {
    set {
      LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_class_version_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_PLANESURFACE_class_version_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Entity_PLANESURFACE() : this(LibreDWGPINVOKE.new_Dwg_Entity_PLANESURFACE(), true) {
  }

}
