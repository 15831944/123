//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Entity_LOFTEDSURFACE : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Entity_LOFTEDSURFACE(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Entity_LOFTEDSURFACE obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Entity_LOFTEDSURFACE() {
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
          LibreDWGPINVOKE.delete_Dwg_Entity_LOFTEDSURFACE(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Entity parent {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_parent_set(swigCPtr, Dwg_Object_Entity.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_parent_get(swigCPtr);
      Dwg_Object_Entity ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Entity(cPtr, false);
      return ret;
    } 
  }

  public byte acis_empty {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_acis_empty_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_acis_empty_get(swigCPtr);
      return ret;
    } 
  }

  public byte unknown {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_unknown_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_unknown_get(swigCPtr);
      return ret;
    } 
  }

  public ushort version {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_version_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_version_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_blocks {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_num_blocks_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_num_blocks_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_int block_size {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_block_size_set(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_block_size_get(swigCPtr);
      SWIGTYPE_p_unsigned_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_char encr_sat_data {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_encr_sat_data_set(swigCPtr, SWIGTYPE_p_p_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_encr_sat_data_get(swigCPtr);
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char acis_data {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_acis_data_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_acis_data_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public byte wireframe_data_present {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_wireframe_data_present_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_wireframe_data_present_get(swigCPtr);
      return ret;
    } 
  }

  public byte point_present {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_point_present_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_point_present_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD point {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_point_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_point_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public uint isolines {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_isolines_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_isolines_get(swigCPtr);
      return ret;
    } 
  }

  public byte isoline_present {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_isoline_present_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_isoline_present_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_wires {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_num_wires_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_num_wires_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_3DSOLID_wire wires {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_wires_set(swigCPtr, Dwg_3DSOLID_wire.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_wires_get(swigCPtr);
      Dwg_3DSOLID_wire ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_3DSOLID_wire(cPtr, false);
      return ret;
    } 
  }

  public uint num_silhouettes {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_num_silhouettes_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_num_silhouettes_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_3DSOLID_silhouette silhouettes {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_silhouettes_set(swigCPtr, Dwg_3DSOLID_silhouette.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_silhouettes_get(swigCPtr);
      Dwg_3DSOLID_silhouette ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_3DSOLID_silhouette(cPtr, false);
      return ret;
    } 
  }

  public byte acis_empty2 {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_acis_empty2_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_acis_empty2_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Entity__3DSOLID extra_acis_data {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_extra_acis_data_set(swigCPtr, Dwg_Entity__3DSOLID.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_extra_acis_data_get(swigCPtr);
      Dwg_Entity__3DSOLID ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Entity__3DSOLID(cPtr, false);
      return ret;
    } 
  }

  public uint unknown_2007 {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_unknown_2007_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_unknown_2007_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref history_id {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_history_id_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_history_id_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public byte acis_empty_bit {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_acis_empty_bit_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_acis_empty_bit_get(swigCPtr);
      return ret;
    } 
  }

  public ushort modeler_format_version {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_modeler_format_version_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_modeler_format_version_get(swigCPtr);
      return ret;
    } 
  }

  public ushort u_isolines {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_u_isolines_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_u_isolines_get(swigCPtr);
      return ret;
    } 
  }

  public ushort v_isolines {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_v_isolines_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_v_isolines_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_double loft_entity_transmatrix {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_loft_entity_transmatrix_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_loft_entity_transmatrix_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public uint plane_normal_lofting_type {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_plane_normal_lofting_type_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_plane_normal_lofting_type_get(swigCPtr);
      return ret;
    } 
  }

  public double start_draft_angle {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_start_draft_angle_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_start_draft_angle_get(swigCPtr);
      return ret;
    } 
  }

  public double end_draft_angle {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_end_draft_angle_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_end_draft_angle_get(swigCPtr);
      return ret;
    } 
  }

  public double start_draft_magnitude {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_start_draft_magnitude_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_start_draft_magnitude_get(swigCPtr);
      return ret;
    } 
  }

  public double end_draft_magnitude {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_end_draft_magnitude_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_end_draft_magnitude_get(swigCPtr);
      return ret;
    } 
  }

  public byte arc_length_parameterization {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_arc_length_parameterization_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_arc_length_parameterization_get(swigCPtr);
      return ret;
    } 
  }

  public byte no_twist {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_no_twist_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_no_twist_get(swigCPtr);
      return ret;
    } 
  }

  public byte align_direction {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_align_direction_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_align_direction_get(swigCPtr);
      return ret;
    } 
  }

  public byte simple_surfaces {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_simple_surfaces_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_simple_surfaces_get(swigCPtr);
      return ret;
    } 
  }

  public byte closed_surfaces {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_closed_surfaces_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_closed_surfaces_get(swigCPtr);
      return ret;
    } 
  }

  public byte solid {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_solid_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_solid_get(swigCPtr);
      return ret;
    } 
  }

  public byte ruled_surface {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_ruled_surface_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_ruled_surface_get(swigCPtr);
      return ret;
    } 
  }

  public byte virtual_guide {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_virtual_guide_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_virtual_guide_get(swigCPtr);
      return ret;
    } 
  }

  public ushort num_cross_sections {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_num_cross_sections_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_num_cross_sections_get(swigCPtr);
      return ret;
    } 
  }

  public ushort num_guide_curves {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_num_guide_curves_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_num_guide_curves_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_p__dwg_object_ref cross_sections {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_cross_sections_set(swigCPtr, SWIGTYPE_p_p__dwg_object_ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_cross_sections_get(swigCPtr);
      SWIGTYPE_p_p__dwg_object_ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p__dwg_object_ref(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p__dwg_object_ref guide_curves {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_guide_curves_set(swigCPtr, SWIGTYPE_p_p__dwg_object_ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_guide_curves_get(swigCPtr);
      SWIGTYPE_p_p__dwg_object_ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p__dwg_object_ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref path_curve {
    set {
      LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_path_curve_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_LOFTEDSURFACE_path_curve_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Entity_LOFTEDSURFACE() : this(LibreDWGPINVOKE.new_Dwg_Entity_LOFTEDSURFACE(), true) {
  }

}
